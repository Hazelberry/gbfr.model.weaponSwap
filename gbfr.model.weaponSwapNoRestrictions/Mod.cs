using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

using Reloaded.Mod.Interfaces;

using gbfr.model.weaponSwapNoRestrictions.Configuration;
using gbfr.model.weaponSwapNoRestrictions.Template;
using gbfrelink.utility.manager.Interfaces;

using GBFRDataTools.Files;
using GBFRDataTools.FlatBuffers;

using FlatSharp;

namespace gbfr.model.weaponSwapNoRestrictions;

/// <summary>
/// Your mod logic goes here.
/// </summary>
public class Mod : ModBase // <= Do not Remove.
{
    /// <summary>
    /// Provides access to the mod loader API.
    /// </summary>
    private readonly IModLoader _modLoader;

    /// <summary>
    /// Provides access to the Reloaded logger.
    /// </summary>
    private readonly ILogger _logger;

    /// <summary>
    /// Entry point into the mod, instance that created this class.
    /// </summary>
    private readonly IMod _owner;

    /// <summary>
    /// Provides access to this mod's configuration.
    /// </summary>
    private Config _configuration;

    /// <summary>
    /// The configuration of the currently executing mod.
    /// </summary>
    private readonly IModConfig _modConfig;

    private WeakReference<IDataManager> _dataManagerRef;

    private ObjReadAppend _objRead;

    private ModelInfo _modelInfo;

    private Dictionary<string, byte[]> _originalFiles = new();

    public Mod(ModContext context)
    {
        _modLoader = context.ModLoader;
        _logger = context.Logger;
        _owner = context.Owner;
        _configuration = context.Configuration;
        _modConfig = context.ModConfig;

#if DEBUG
        // NOTE (Nenkai): Only works with unpacked exe (use steamless)
        // Ensure that another mod isn't also launching the debugger (use release mode for any other mods)
        Debugger.Launch();
#endif

        _logger.WriteLine($"[{_modConfig.ModId}] Initializing...");
        _dataManagerRef = _modLoader.GetController<IDataManager>();
        if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
            return;

        ApplyModelSwap();
        manager.UpdateIndex();

        _logger.WriteLine($"[{_modConfig.ModId}] Initialized.");
    }

    public void ApplyModelSwap()
    {
        if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
            return;

        Dictionary<uint, uint> weaponIdList = new()
        {
            { (uint)CaptainWeaponObjId.Travellers_Sword, (uint)_configuration.Captain_TravellersSword                 },
            { (uint)CaptainWeaponObjId.Durandal, (uint)_configuration.Captain_Durandal                                },
            { (uint)CaptainWeaponObjId.Sword_of_Eos, (uint)_configuration.Captain_SwordofEos                          },
            { (uint)CaptainWeaponObjId.Albacore_Blade, (uint)_configuration.Captain_AlbacoreBlade                     },
            { (uint)CaptainWeaponObjId.Ultima_Sword, (uint)_configuration.Captain_UltimaSword                         },
            { (uint)CaptainWeaponObjId.Seven_Star_Sword, (uint)_configuration.Captain_SevenStarSword                  },
            { (uint)CaptainWeaponObjId.Partenza, (uint)_configuration.Captain_Partenza                                },

            { (uint)KatalinaWeaponObjId.Rukalsa, (uint)_configuration.Katalina_Rukalsa                                },
            { (uint)KatalinaWeaponObjId.Flame_Rapier, (uint)_configuration.Katalina_FlameRapier                       },
            { (uint)KatalinaWeaponObjId.Murgleis, (uint)_configuration.Katalina_Murgleis                              },
            { (uint)KatalinaWeaponObjId.Luminiera_Sword_Omega, (uint)_configuration.Katalina_LuminieraSwordOmega      },
            { (uint)KatalinaWeaponObjId.Ephemeron, (uint)_configuration.Katalina_Ephemeron                            },
            { (uint)KatalinaWeaponObjId.Blutgang, (uint)_configuration.Katalina_Blutgang                              },

            { (uint)RackamWeaponObjId.Flintspike, (uint)_configuration.Rackam_Flintspike                              },
            { (uint)RackamWeaponObjId.Wheellock_Axe, (uint)_configuration.Rackam_WheellockAxe                         },
            { (uint)RackamWeaponObjId.Benedia, (uint)_configuration.Rackam_Benedia                                    },
            { (uint)RackamWeaponObjId.Tiamat_Bolt_Omega, (uint)_configuration.Rackam_TiamatBoltOmega                  },
            { (uint)RackamWeaponObjId.Stormcloud, (uint)_configuration.Rackam_Stormcloud                              },
            { (uint)RackamWeaponObjId.Freikugel, (uint)_configuration.Rackam_Freikugel                                },

            { (uint)IoWeaponObjId.Little_Witch_Scepter, (uint)_configuration.Io_LittleWitchScepter                    },
            { (uint)IoWeaponObjId.Zhezl, (uint)_configuration.Io_Zhezl                                                },
            { (uint)IoWeaponObjId.Gambanteinn, (uint)_configuration.Io_Gambanteinn                                    },
            { (uint)IoWeaponObjId.Colossus_Cane_Omega, (uint)_configuration.Io_ColossusCaneOmega                      },
            { (uint)IoWeaponObjId.Tupsimati, (uint)_configuration.Io_Tupsimati                                        },
            { (uint)IoWeaponObjId.Caduceus, (uint)_configuration.Io_Caduceus                                          },

            { (uint)EugenWeaponObjId.Dreyse, (uint)_configuration.Eugen_Dreyse                                        },
            { (uint)EugenWeaponObjId.Matchlock, (uint)_configuration.Eugen_Matchlock                                  },
            { (uint)EugenWeaponObjId.AK4A, (uint)_configuration.Eugen_AK4A                                            },
            { (uint)EugenWeaponObjId.Leviathan_Muzzle, (uint)_configuration.Eugen_LeviathanMuzzle                     },
            { (uint)EugenWeaponObjId.Clarion, (uint)_configuration.Eugen_Clarion                                      },
            { (uint)EugenWeaponObjId.Draconic_Fire, (uint)_configuration.Eugen_DraconicFire                           },

            { (uint)RosettaWeaponObjId.Egoism, (uint)_configuration.Rosetta_Egoism                                    },
            { (uint)RosettaWeaponObjId.Swordbreaker, (uint)_configuration.Rosetta_Swordbreaker                        },
            { (uint)RosettaWeaponObjId.Love_Eternal, (uint)_configuration.Rosetta_LoveEternal                         },
            { (uint)RosettaWeaponObjId.Rose_Crystal_Knife, (uint)_configuration.Rosetta_RoseCrystalKnife              },
            { (uint)RosettaWeaponObjId.Cortana, (uint)_configuration.Rosetta_Cortana                                  },
            { (uint)RosettaWeaponObjId.Dagger_of_Bahamut_Coda, (uint)_configuration.Rosetta_DaggerofBahamutCoda       },

            { (uint)FerryWeaponObjId.Geisterpeitche, (uint)_configuration.Ferry_Geisterpeitche                        },
            { (uint)FerryWeaponObjId.Leather_Belt, (uint)_configuration.Ferry_LeatherBelt                             },
            { (uint)FerryWeaponObjId.Ethereal_Lasher, (uint)_configuration.Ferry_EtherealLasher                       },
            { (uint)FerryWeaponObjId.Flame_Lit_Curl, (uint)_configuration.Ferry_FlameLitCurl                          },
            { (uint)FerryWeaponObjId.Live_Wire, (uint)_configuration.Ferry_LiveWire                                   },
            { (uint)FerryWeaponObjId.Erinnerung, (uint)_configuration.Ferry_Erinnerung                                },

            { (uint)LancelotWeaponObjId.Altachiara, (uint)_configuration.Lancelot_Altachiara                          },
            { (uint)LancelotWeaponObjId.Hoarfrost_Blade_Persius, (uint)_configuration.Lancelot_HoarfrostBladePersius  },
            { (uint)LancelotWeaponObjId.Blanc_Comme_Neige, (uint)_configuration.Lancelot_BlancCommeNeige              },
            { (uint)LancelotWeaponObjId.Vegalta, (uint)_configuration.Lancelot_Vegalta                                },
            { (uint)LancelotWeaponObjId.Knight_of_Ice, (uint)_configuration.Lancelot_KnightOfIce                      },
            { (uint)LancelotWeaponObjId.Damascus_Knife, (uint)_configuration.Lancelot_DamascusKnife                   },

            { (uint)VaneWeaponObjId.Alabarda, (uint)_configuration.Vane_Alabarda                                      },
            { (uint)VaneWeaponObjId.Swan, (uint)_configuration.Vane_Swan                                              },
            { (uint)VaneWeaponObjId.Treuer_Krieger, (uint)_configuration.Vane_TreuerKrieger                           },
            { (uint)VaneWeaponObjId.Ukonvasara, (uint)_configuration.Vane_Ukonvasara                                  },
            { (uint)VaneWeaponObjId.Blossom_Axe, (uint)_configuration.Vane_BlossomAxe                                 },
            { (uint)VaneWeaponObjId.Mjolnir, (uint)_configuration.Vane_Mjolnir                                        },

            { (uint)PercivalWeaponObjId.Flamberge, (uint)_configuration.Percival_Flamberge                            },
            { (uint)PercivalWeaponObjId.Lohengrin, (uint)_configuration.Percival_Lohengrin                            },
            { (uint)PercivalWeaponObjId.Antwerp, (uint)_configuration.Percival_Antwerp                                },
            { (uint)PercivalWeaponObjId.Joyeuse, (uint)_configuration.Percival_Joyeuse                                },
            { (uint)PercivalWeaponObjId.Lord_of_Flames, (uint)_configuration.Percival_LordOfFlames                    },
            { (uint)PercivalWeaponObjId.Gottfried, (uint)_configuration.Percival_Gottfried                            },

            { (uint)SiegfriedWeaponObjId.Integrity, (uint)_configuration.Siegfried_Integrity                          },
            { (uint)SiegfriedWeaponObjId.Broadsword_of_Earth, (uint)_configuration.Siegfried_BroadswordofEarth        },
            { (uint)SiegfriedWeaponObjId.Ascalon, (uint)_configuration.Siegfried_Ascalon                              },
            { (uint)SiegfriedWeaponObjId.Hrunting, (uint)_configuration.Siegfried_Hrunting                            },
            { (uint)SiegfriedWeaponObjId.Windhose, (uint)_configuration.Siegfried_Windhose                            },
            { (uint)SiegfriedWeaponObjId.Balmung, (uint)_configuration.Siegfried_Balmung                              },

            { (uint)CharlottaWeaponObjId.Claiomh_Solais, (uint)_configuration.Charlotta_ClaiomhSolais                 },
            { (uint)CharlottaWeaponObjId.Arondight, (uint)_configuration.Charlotta_Arondight                          },
            { (uint)CharlottaWeaponObjId.Claidheamh_Soluis, (uint)_configuration.Charlotta_ClaidheamhSoluis           },
            { (uint)CharlottaWeaponObjId.Ushumgal, (uint)_configuration.Charlotta_Ushumgal                            },
            { (uint)CharlottaWeaponObjId.Sahrivar, (uint)_configuration.Charlotta_Sahrivar                            },
            { (uint)CharlottaWeaponObjId.Galatine, (uint)_configuration.Charlotta_Galatine                            },

            { (uint)YodarhaWeaponObjId.Kiku_Ichimonji, (uint)_configuration.Yodarha_KikuIchimonji                     },
            { (uint)YodarhaWeaponObjId.Asura, (uint)_configuration.Yodarha_Asura                                      },
            { (uint)YodarhaWeaponObjId.Fudo_Kuniyuki, (uint)_configuration.Yodarha_FudoKuniyuki                       },
            { (uint)YodarhaWeaponObjId.Higurashi, (uint)_configuration.Yodarha_Higurashi                              },
            { (uint)YodarhaWeaponObjId.Xeno_Phantom_Demon_Blade, (uint)_configuration.Yodarha_XenoPhantomDemonBlade   },
            { (uint)YodarhaWeaponObjId.Swordfish, (uint)_configuration.Yodarha_Swordfish                              },

            { (uint)NarmayaWeaponObjId.Nakamaki_Nodachi, (uint)_configuration.Narmaya_NakamakiNodachi                 },
            { (uint)NarmayaWeaponObjId.Kotetsu, (uint)_configuration.Narmaya_Kotetsu                                  },
            { (uint)NarmayaWeaponObjId.Venustas, (uint)_configuration.Narmaya_Venustas                                },
            { (uint)NarmayaWeaponObjId.Flourithium_Blade, (uint)_configuration.Narmaya_Flourithium_Blade              },
            { (uint)NarmayaWeaponObjId.Blade_of_Purification, (uint)_configuration.Narmaya_BladeofPurification        },
            { (uint)NarmayaWeaponObjId.Ameno_Habakiri, (uint)_configuration.Narmaya_AmenoHabakiri                     },

            { (uint)GhandagozaWeaponObjId.Brahma_Gauntlet, (uint)_configuration.Ghandagoza_BrahmaGauntlet             },
            { (uint)GhandagozaWeaponObjId.Rope_Knuckles, (uint)_configuration.Ghandagoza_RopeKnuckles                 },
            { (uint)GhandagozaWeaponObjId.Crimson_Finger, (uint)_configuration.Ghandagoza_CrimsonFinger               },
            { (uint)GhandagozaWeaponObjId.Golden_Fists_of_Ura, (uint)_configuration.Ghandagoza_GoldenFistsOfUra       },
            { (uint)GhandagozaWeaponObjId.Arkab, (uint)_configuration.Ghandagoza_Arkab                                },
            { (uint)GhandagozaWeaponObjId.Sky_Piercer, (uint)_configuration.Ghandagoza_SkyPiercer                     },

            { (uint)ZetaWeaponObjId.Spear_of_Arvess, (uint)_configuration.Zeta_SpearofArvess                          },
            { (uint)ZetaWeaponObjId.Sunspot_Spear, (uint)_configuration.Zeta_Sunspot_Spear                            },
            { (uint)ZetaWeaponObjId.Brionac, (uint)_configuration.Zeta_Brionac                                        },
            { (uint)ZetaWeaponObjId.Gisla, (uint)_configuration.Zeta_Gisla                                            },
            { (uint)ZetaWeaponObjId.Huanglong_Spear, (uint)_configuration.Zeta_HuanglongSpear                         },
            { (uint)ZetaWeaponObjId.Gae_Bulg, (uint)_configuration.Zeta_GaeBulg                                       },

            { (uint)VaseragaWeaponObjId.Great_Scythe_Grynoth, (uint)_configuration.Vaseraga_GreatScytheGrynoth        },
            { (uint)VaseragaWeaponObjId.Alsarav, (uint)_configuration.Vaseraga_Alsarav                                },
            { (uint)VaseragaWeaponObjId.Wurtzite_Scythe, (uint)_configuration.Vaseraga_WurtziteScythe                 },
            { (uint)VaseragaWeaponObjId.Soul_Eater, (uint)_configuration.Vaseraga_SoulEater                           },
            { (uint)VaseragaWeaponObjId.Cosmic_Scythe, (uint)_configuration.Vaseraga_CosmicScythe                     },
            { (uint)VaseragaWeaponObjId.Ereshkigal, (uint)_configuration.Vaseraga_Ereshkigal                          },

            { (uint)CagliostroWeaponObjId.Magnum_Opus, (uint)_configuration.Cagliostro_MagnumOpus                     },
            { (uint)CagliostroWeaponObjId.Dream_Atlas, (uint)_configuration.Cagliostro_DreamAtlas                     },
            { (uint)CagliostroWeaponObjId.Transmigration_Tome, (uint)_configuration.Cagliostro_TransmigrationTome     },
            { (uint)CagliostroWeaponObjId.Sacred_Codex, (uint)_configuration.Cagliostro_SacredCodex                   },
            { (uint)CagliostroWeaponObjId.Arshivelle, (uint)_configuration.Cagliostro_Arshivelle                      },
            { (uint)CagliostroWeaponObjId.Zosimos, (uint)_configuration.Cagliostro_Zosimos                            },

            { (uint)IdWeaponObjId.Ragnarok, (uint)_configuration.Id_Ragnarok                                          },
            { (uint)IdWeaponObjId.Aviaeth_Faussart, (uint)_configuration.Id_AviaethFaussart                           },
            { (uint)IdWeaponObjId.Susanoo, (uint)_configuration.Id_Susanoo                                            },
            { (uint)IdWeaponObjId.Premium_Sword, (uint)_configuration.Id_PremiumSword                                 },
            { (uint)IdWeaponObjId.Ecke_Sachs, (uint)_configuration.Id_EckeSachs                                       },
            { (uint)IdWeaponObjId.Sword_of_Bahamut, (uint)_configuration.Id_SwordofBahamut                            },

            { (uint)SeofonWeaponObjId.Sette_di_Spade, (uint)_configuration.Seofon_SettediSpade                        },
            { (uint)SeofonWeaponObjId.Gateway_Star_Sword, (uint)_configuration.Seofon_GatewayStarSword                },

            { (uint)TweyenWeaponObjId.Bow_of_Dismissal, (uint)_configuration.Tweyen_BowofDismissal                    },
            { (uint)TweyenWeaponObjId.Desolation_Crown_Bow, (uint)_configuration.Tweyen_DesolationCrownBow            },

            { (uint)SandalphonWeaponObjId.Apprentice, (uint)_configuration.Sandalphon_Apprentice                      },
            { (uint)SandalphonWeaponObjId.WorldEnder, (uint)_configuration.Sandalphon_WorldEnder                      },

        };

        //string infoFile = "system/objread/info.objread";
        //if (!manager.FileExists(infoFile, includeExternal: false))
        //    return;

        //byte[] fileBytes = manager.GetArchiveFile(infoFile);
        //_objRead = ObjReadAppend.Serializer.Parse(fileBytes);

        //foreach (var weapon in weaponIdList)
        //    ProcessInfoObjread(weapon.Key, weapon.Value); // Currently breaks glow on some weapons

        //byte[] outputBuffer = new byte[ObjReadAppend.Serializer.GetMaxSize(_objRead)];
        //int length = ObjReadAppend.Serializer.Write(outputBuffer, _objRead);

        //manager.AddOrUpdateExternalFile(infoFile,
        //    outputBuffer.AsSpan(0, length).ToArray());

        ///----------------------------------------------------------------------------///

        ProcessModels(weaponIdList); // Processes files directly. Does not work with modded weapons.

        ///----------------------------------------------------------------------------///

        Dictionary<uint, uint> captainIdList = new()
        {
            { (uint)CaptainWeaponObjId.Durandal, (uint)_configuration.Captain_Durandal                                },
            { (uint)CaptainWeaponObjId.Sword_of_Eos, (uint)_configuration.Captain_SwordofEos                          },
            { (uint)CaptainWeaponObjId.Albacore_Blade, (uint)_configuration.Captain_AlbacoreBlade                     },
            { (uint)CaptainWeaponObjId.Ultima_Sword, (uint)_configuration.Captain_UltimaSword                         },
            { (uint)CaptainWeaponObjId.Seven_Star_Sword, (uint)_configuration.Captain_SevenStarSword                  },
            { (uint)CaptainWeaponObjId.Partenza, (uint)_configuration.Captain_Partenza                                },
        };

        Dictionary<uint, uint> narmayaIdList = new()
        {
            { (uint)NarmayaWeaponObjId.Nakamaki_Nodachi, (uint)_configuration.Narmaya_NakamakiNodachi                 },
            { (uint)NarmayaWeaponObjId.Kotetsu, (uint)_configuration.Narmaya_Kotetsu                                  },
            { (uint)NarmayaWeaponObjId.Venustas, (uint)_configuration.Narmaya_Venustas                                },
            { (uint)NarmayaWeaponObjId.Flourithium_Blade, (uint)_configuration.Narmaya_Flourithium_Blade              },
            { (uint)NarmayaWeaponObjId.Blade_of_Purification, (uint)_configuration.Narmaya_BladeofPurification        },
            { (uint)NarmayaWeaponObjId.Ameno_Habakiri, (uint)_configuration.Narmaya_AmenoHabakiri                     },
        };


        foreach (var elem in captainIdList)
        {
            if (elem.Key != elem.Value && _configuration.Captain_SheathSwapToggle == Toggle.Enabled && ObjIdToCharacterId(elem.Value) == "0000")
            {
                ProcessSheaths(captainIdList, "0101");
                break;
            }
        }

        foreach (var elem in narmayaIdList)
        {
            if (elem.Key != elem.Value && _configuration.Narmaya_SheathSwapToggle == Toggle.Enabled && ObjIdToCharacterId(elem.Key) == "1400")
            {
                ProcessSheaths(narmayaIdList, "1400");
                break;
            }
        }
    }

    public void ProcessInfoObjread(uint sourceHex, uint targetHex)
    {
        if (targetHex == sourceHex)
            return;

        //_logger.WriteLine($"Passed checks, trying to replace {sourceHex:X8} with {targetHex:X8}");

        try
        {
            var searchResult = _objRead.Entries.BinarySearchByFlatBufferKey(sourceHex);

            uint targetHexAlt = targetHex & 0xFFFFFF00;

            if (searchResult is null)
            {
                _logger.WriteLine($"Replacing {ObjIdToModelId(sourceHex)} with {ObjIdToModelId(targetHex)}. No entry found, making new entry.");

                Info newInfo = new()
                {
                    SearchObjidKey = sourceHex,
                    UnkObjid2 = targetHexAlt,
                    UnkObjid3 = targetHex,
                    UnkObjid5 = targetHex,
                    UnkObjid6 = targetHexAlt,
                    UnkObjid7 = targetHex,
                    UnkObjid8 = targetHex
                };
                _objRead.Entries.Add(newInfo);
            }
            else
            {
                _logger.WriteLine($"Replacing {ObjIdToModelId(sourceHex)} with {ObjIdToModelId(targetHex)}");
                searchResult.UnkObjid3 = targetHex;
                searchResult.UnkObjid5 = targetHex;
                searchResult.UnkObjid7 = targetHex;
                searchResult.UnkObjid8 = targetHex;
            }

            ProcessPhysics(sourceHex, targetHex);
        }
        catch (Exception ex)
        {
            _logger.WriteLine($"[{_modConfig.ModId}] Failed to apply {ObjIdToModelId(sourceHex)} model patch - {ex.Message}");
        }
    }

    public void ProcessModels(Dictionary<uint, uint> weaponObjIdList)
    {
        if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
            return;

        foreach (var elem in weaponObjIdList)
        {
            if (elem.Value != elem.Key) // Check if config different from source
            {
                string sourceModelId = ObjIdToModelId(elem.Key);    // Original files that will be replaced
                string targetModelId = ObjIdToModelId(elem.Value);  // New files

                List<string> sourcePaths = ObjIdToModelPaths(sourceModelId);
                List<string> targetPaths = ObjIdToModelPaths(targetModelId);

                if (elem.Value == (uint)CaptainWeaponObjId.Sword_of_Eos) // Weirdly has an extra mmat file
                {
                    targetPaths.Add("model/wp/wp0002/vars/1.mmat");
                    sourcePaths.Add($"model/wp/{ObjIdToModelId(elem.Key)}/vars/1.mmat");
                }

                foreach (var target in targetPaths)
                {
                    if (!manager.FileExists(target, includeExternal: false) && !_originalFiles.TryGetValue(target, out _))
                    {
                        _logger.WriteLine($"{target} not found, cancelling replacement of {sourceModelId}");
                        return;
                    }
                }

                ProcessFiles(sourcePaths, targetPaths);

                ProcessPhysics(elem.Key, elem.Value);
            }
        }
    }

    public void ProcessSheaths(Dictionary<uint, uint> idList, string characterId)
    {
        if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
            return;

        int skipCount = 0;
        foreach (var elem in idList)
        {
            if ((characterId == "1400" && ObjIdToCharacterId(elem.Value) != "1400") || (characterId == "0101" && ObjIdToCharacterId(elem.Value) != "0000") || elem.Key == elem.Value)
            {
                skipCount++;
            }
        }
        if (skipCount == idList.Count) // Skips the whole method if all the values are matching and/or other characters' weapons
        {
            return;
        }

        _logger.WriteLine($"Swapping sheaths for {(characterId == "0101" ? "Djeeta" : "Narmaya")}");

        string characterMInfo;

        if (characterId == "1400" || characterId == "0101")
        {
            characterMInfo = $"model/pl/pl{characterId}/pl{characterId}.minfo";
        }
        else
        {
            _logger.WriteLine($"Character {characterId} does not have a swappable sheath, this method should not have been called.");
            return;
        }

        if (!manager.FileExists(characterMInfo, includeExternal: false))
        {
            _logger.WriteLine($"\nCan't find {characterMInfo}, skipping sheath swap.\nIf the character model has been modified by another mod the sheath can not be changed.\n");
            return;
        }

        byte[] fileBytes = manager.GetArchiveFile(characterMInfo);
        _modelInfo = ModelInfo.Serializer.Parse(fileBytes);
        var modelInfoBackup = ModelInfo.Serializer.Parse(fileBytes);

        foreach (var elem in idList)
        {
            if ((characterId == "1400" && ObjIdToCharacterId(elem.Value) != "1400") || (characterId == "0101" && ObjIdToCharacterId(elem.Value) != "0000") || elem.Key == elem.Value) // Skip if config is set to another character's weapon or the same
            {
                continue;
            }

            string sourceSheath = ObjIdToSheathId(elem.Key);
            string targetSheath = ObjIdToSheathId(elem.Value);

            _logger.WriteLine($"Changing {sourceSheath} to {targetSheath}");

            if (characterId == "1400")
            {
                Dictionary<string, int> subMeshNumber = new()
                {
                    { "a50_sheath", 0 },
                    { "a40_sheath", 1 },
                    { "a30_sheath", 2 },
                    { "a20_sheath", 3 },
                    { "a10_sheath", 4 },
                    { "a00_sheath", 5 },
                };

                List<int> sourceLodIndices = new();
                List<int> targetLodIndices = new();

                for (int i = 0; i < modelInfoBackup.Lods.Count; i++)
                {
                    for (int j = 0; j < modelInfoBackup.Lods[i].Chunks.Count; j++)
                    {
                        if (modelInfoBackup.Lods[i].Chunks[j].SubMeshId == subMeshNumber[sourceSheath])
                        {
                            sourceLodIndices.Add(j);
                            break;
                        }
                    }

                    for (int j = 0; j < modelInfoBackup.Lods[i].Chunks.Count; j++)
                    {
                        if (modelInfoBackup.Lods[i].Chunks[j].SubMeshId == subMeshNumber[targetSheath])
                        {
                            targetLodIndices.Add(j);
                            break;
                        }
                    }
                }

                if (sourceLodIndices.Count != targetLodIndices.Count)
                {
                    _logger.WriteLine($"{sourceSheath} indices mismatch, exiting ProcessSheaths");
                    return;
                }

                for (int i = 0; i < _modelInfo.Lods.Count; i++)
                {
                    for (int j = 0; j < sourceLodIndices.Count; j++)
                    {
                        var sourceLodData = _modelInfo.Lods[i].Chunks[sourceLodIndices[j]];
                        var targetLodData = modelInfoBackup.Lods[i].Chunks[targetLodIndices[j]];

                        sourceLodData.MaterialId = targetLodData.MaterialId;
                    }
                }
            }

            int sourceIndex = -1;
            int targetIndex = -1;

            for (int i = 0; i < modelInfoBackup.SubMeshes.Count; i++)
            {
                if (modelInfoBackup.SubMeshes[i].Name == sourceSheath)
                {
                    sourceIndex = i;
                    break;
                }
            }

            for (int i = 0; i < modelInfoBackup.SubMeshes.Count; i++)
            {
                if (modelInfoBackup.SubMeshes[i].Name == targetSheath)
                {
                    targetIndex = i;
                    break;
                }
            }

            var sourceData = _modelInfo.SubMeshes[sourceIndex];
            var targetData = modelInfoBackup.SubMeshes[targetIndex];

            string sourceDataName;
            BoundaryBox sourceDataBbox;

            if ((characterId == "0101" && _configuration.Captain_SheathSwapToggle == Toggle.Enabled) || elem.Key == (uint)CaptainWeaponObjId.Partenza)
            {
                sourceData.Name = targetData.Name;
                sourceData.Bbox = targetData.Bbox;
            }
            else if (characterId == "1400")
            {
                sourceDataName = sourceData.Name;
                sourceDataBbox = sourceData.Bbox;

                sourceData.Name = targetData.Name;
                sourceData.Bbox = targetData.Bbox;
                _modelInfo.SubMeshes[targetIndex].Name = sourceDataName;
                _modelInfo.SubMeshes[targetIndex].Bbox = sourceDataBbox;
            }
        }

        byte[] outputBuffer = new byte[ModelInfo.Serializer.GetMaxSize(_modelInfo)];
        int length = ModelInfo.Serializer.Write(outputBuffer, _modelInfo);

        manager.AddOrUpdateExternalFile(characterMInfo,
            outputBuffer.AsSpan(0, length).ToArray());
    }

    public void ProcessPhysics(uint sourceHex, uint targetHex)
    {
        if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
            return;

        string sourceModelId = ObjIdToModelId(sourceHex); //Original files that will be replaced
        string targetModelId = ObjIdToModelId(targetHex); //New files

        List<string> filePathFormats = new()
        {
            "{1}/{0}/cloth/{0}_0_{2}_clp.bxm",
            "{1}/{0}/cloth/{0}_0_{2}_clh.bxm", // Controls position, basically keeps stuff with physics where they should be. Not used by all weapons.
        };

        List<string> sourcePaths = new();
        List<string> targetPaths = new();

        for (int i = 0; i < 10; i++)
        {
            int count = targetPaths.Count;

            foreach (var format in filePathFormats)
            {
                sourcePaths.Add(string.Format(format, sourceModelId, sourceModelId[..2], i));
                targetPaths.Add(string.Format(format, targetModelId, targetModelId[..2], i));
            }

            for (int j = targetPaths.Count - 1; j > count - 1; j--)
            {
                if (!manager.FileExists(targetPaths[j], includeExternal: false) && !_originalFiles.TryGetValue(targetPaths[j], out _))
                {
                    sourcePaths.RemoveAt(j);
                    targetPaths.RemoveAt(j);
                }
            }

            if (targetPaths.Count == count)
                break;
        }

        if (targetPaths.Count > 0)
        {
            ProcessFiles(sourcePaths, targetPaths);
        }
    }

    public void ProcessFiles(List<string> sourcePaths, List<string> targetPaths)
    {
        if (!_dataManagerRef.TryGetTarget(out IDataManager manager))
            return;

        for (int i = 0; i < targetPaths.Count; i++)
        {
            if (manager.FileExists(targetPaths[i], includeExternal: false))
            {
                byte[] targetFile = manager.GetArchiveFile(targetPaths[i]);
                byte[] sourceBytes;

                // Store the source if it exists
                if (manager.FileExists(sourcePaths[i], includeExternal: false))
                {
                    sourceBytes = manager.GetArchiveFile(sourcePaths[i]);
                    _originalFiles.Add(sourcePaths[i], sourceBytes);
                }

                manager.AddOrUpdateExternalFile(sourcePaths[i], targetFile);
            }
            else if (_originalFiles.TryGetValue(targetPaths[i], out byte[] byteData))
            {
                manager.AddOrUpdateExternalFile(sourcePaths[i], byteData);
            }
            else
            {
                _logger.WriteLine($"{targetPaths[i]} not found");
                return;
            }
        }
    }

    static string ObjIdToModelId(uint objId)
    {
        uint category = objId >> 16;
        uint modelId = objId & 0xFFFF;

        return category switch
        {
            0x01 => $"pl{modelId:X4}",
            0x02 => $"em{modelId:X4}",
            0x03 => $"wp{modelId:X4}",
            0x04 => $"et{modelId:X4}",
            0x05 => $"ef{modelId:X4}",
            0x07 => $"it{modelId:X4}",
            0x09 => $"sc{modelId:X4}",
            0x0C => $"bg{modelId:X4}",
            0x0E => $"bh{modelId:X4}",
            0x0F => $"ba{modelId:X4}",
            0x100 => $"fp{modelId:X4}",
            0x101 => $"fe{modelId:X4}",
            0x102 => $"fn{modelId:X4}",
            0x103 => $"we{modelId:X4}",
            0x104 => $"wn{modelId:X4}",
            0x10A => $"np{modelId:X4}",
            0x10B => $"tr{modelId:X4}",
            0x10C => $"bt{modelId:X4}",
            _ => throw new ArgumentException($"Invalid object id category {category}", nameof(objId))
        };
    }

    static string ObjIdToSheathId(uint objId) // Skips Katalina, Gran+Djeeta rebelwear, Gran default, Rosetta, and Yodarha because hiding sheaths is hardcoded into the executable
    {
        /// Weapons that Disable Sheaths
        /// 
        /// Character       | Weapons
        /// ~~~~~~~~~~~~~~~~|~~~~~~~~~~~
        /// Captain Default | Albacore Blade
        /// Captain Rebel   | Albacore Blade
        /// Katalina        | Flame Rapier, Murgleis, Luminiera Sword Omega, Ephermeron, Blutgang
        /// Rosetta         | Love Eternal
        /// Yodarha         | Asura, Fudo-Kuniyuki, Xeno Phantom Demon Blade, Swordfish
        ///

        /// Weapons that Share Sheaths
        /// 
        /// Character               | Weapons
        /// ~~~~~~~~~~~~~~~~~~~~~~~~|~~~~~~~~~~~
        /// Captain Default Thin    | Partenza 
        /// Captain Default Thick   | Traveller's Sword, Durandal, Sword of Eos, Ultima Sword, Seven-Star Sword
        /// Captain Rebel           | Traveller's Sword, Durandal, Sword of Eos, Ultima Sword, Seven-Star Sword, Partenza
        /// Rosetta                 | Egoism, Swordbreaker, Rose Crystal Knife, Cortana, Dagger of Bahamut Coda
        /// Yodarha                 | Kiku-Ichimonji, Higurashi
        /// 

        string characterId = ObjIdToCharacterId(objId);
        char sheathPrefix;
        string sheathId;

        if (characterId == "0000") // Djeeta, only messing with the default outfit but not rebelwear or any of Gran since they have a single large sheath each
        {
            sheathPrefix = 'b';

            if (objId == (uint)CaptainWeaponObjId.Partenza)
            {
                sheathId = $"{sheathPrefix}00_sheath";
            }
            else
            {
                sheathId = $"{sheathPrefix}10_sheath";
            }
        }
        else if (characterId == "1400") // Narmaya
        {
            sheathPrefix = 'a';
            char modelId = $"{(objId & 0xFFFF):X4}"[^1]; // Grabs last number

            sheathId = $"{sheathPrefix}{modelId}0_sheath";
        }
        else
        {
            throw new ArgumentException($"Character {characterId} does not have a swappable sheath, this method should not have been called");
        }

        return sheathId;
    }

    static string ObjIdToCharacterId(uint objId)
    {
        string characterId;
        if (objId == (uint)CaptainWeaponObjId.Partenza) // Converts Partenza to 0000 so it can be grouped with other Captain weapons
            characterId = $"{(objId & 0x0000):X4}";
        else
            characterId = $"{(objId & 0xFF00):X4}";

        return characterId;
    }

    static List<string> ObjIdToModelPaths(string modelId)
    {
        string category = modelId[..2];

        List<string> paths = new();

        List<string> filePathFormats = new()
        {
            "model/{0}/{1}/{1}.minfo",
            "model/{0}/{1}/{1}.skeleton",
            "model/{0}/{1}/vars/0.mmat",
            "model_streaming/lod0/{1}.mmesh",
            "model_streaming/lod1/{1}.mmesh",
            "model_streaming/lod2/{1}.mmesh",
            "model_streaming/lod3/{1}.mmesh",
            //"model_streaming/shadow_lod0/{0}.mmesh", //Not used by weapons
            //"model_streaming/shadow_lod1/{0}.mmesh", //Not used by weapons
            //"model_streaming/shadow_lod2/{0}.mmesh", //Not used by weapons
        };

        foreach (var format in filePathFormats)
        {
            paths.Add(string.Format(format, category, modelId));
        }

        return paths;
    }
    #region Standard Overrides
    public override void ConfigurationUpdated(Config configuration)
    {
        // Apply settings from configuration.
        // ... your code here.
        _configuration = configuration;
        _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
    }
    #endregion

    #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Mod() { }
#pragma warning restore CS8618
    #endregion


}