using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dikkenek_WindowsPhone8._1.Common;
using Dikkenek_WindowsPhone8._1.Models;

namespace Dikkenek_WindowsPhone8._1.ViewModels
{
    public class AppViewModel : BindableBase
    {
        public ObservableDictionary Categories { get; set; }

        public AppViewModel()
        {
            Categories = new ObservableDictionary();
        }
 
        public bool IsDataLoaded { get; private set; }

        public void LoadData()
        {
            if (!IsDataLoaded)
            {
                #region others

                var others = new Category()
                {
                    Name = "Les autres",
                    Picture = "default",
                    Phrases = new List<Phrase>()
                        {
                            new Phrase()
                            {
                                Sound = "merde_veste",
                                Name = "Elle sent la merde ta veste",
                                Picture = "aziz"
                            },
                            new Phrase()
                            {
                                Sound = "poli_ou_pas_poli",
                                Name = "T'es poli ou t'es pas poli ?",
                                Picture = "aziz"
                            },
                            new Phrase()
                            {
                                Sound = "king_route",
                                Name = "C'est moi le king de la route",
                                Picture = "greg"
                            },
                            new Phrase()
                            {
                                Sound = "boire_gros_tas",
                                Name = "Tu bois pas tout, gros tas !",
                                Picture = "grosse"
                            },
                            new Phrase()
                            {
                                Sound = "deux_bieres",
                                Name = "Je peux avoir deux bières ?",
                                Picture = "grosse"
                            },
                            new Phrase()
                            {
                                Sound = "ressemble_pere_moche",
                                Name = "Y ressemble à son père, il est moche, tiens",
                                Picture = "grosse"
                            },
                            new Phrase()
                            {
                                Sound = "licenciement",
                                Name = "Un livre sur le licenciement",
                                Picture = "baudouin"
                            },
                            new Phrase()
                            {
                                Sound = "pays_de_merde",
                                Name = "Quel klet ce peï, trou du cul de merde",
                                Picture = "baudouin"
                            },
                            new Phrase()
                            {
                                Sound = "nenes_cuisses_magasines",
                                Name = "Ça change des magazines, hein !",
                                Picture = "grosse_néné"
                            },
                            new Phrase()
                            {
                                Sound = "dose_de_cheval",
                                Name = "J'ai mis une dose de cheval",
                                Picture = "default"
                            },
                            new Phrase()
                            {
                                Sound = "le_plus_beau",
                                Name = "Voilà le plus beau",
                                Picture = "daisy"
                            },
                            new Phrase()
                            {
                                Sound = "dedicace_chteu",
                                Name = "Je viens d'acheter mon permis",
                                Picture = "fabienne"
                            },
                            new Phrase()
                            {
                                Sound = "cocker_coffre",
                                Name = "Une gamine avec des yeux de cocker dans ton coffre",
                                Picture = "garagiste"
                            },
                            new Phrase()
                            {
                                Sound = "kinder",
                                Name = "Que tu roulais dans un Kinder",
                                Picture = "garagiste"
                            },
                            new Phrase()
                            {
                                Sound = "kdo_caillou",
                                Name = "Tu lui offres des cailloux",
                                Picture = "laurence"
                            },
                            new Phrase()
                            {
                                Sound = "biere",
                                Name = "T'veux une bière ?",
                                Picture = "miche"
                            },
                            new Phrase()
                            {
                                Sound = "coup_de_boule",
                                Name = "Le coup de boule de nouvel an t'a pas suffit ?",
                                Picture = "miche"
                            },
                            new Phrase()
                            {
                                Sound = "ptite_bite",
                                Name = "P'tite bite",
                                Picture = "sylvie"
                            },
                        }
                };
                #endregion others

                #region claudy

                var claudy = new Category()
                {
                    Name = "Claudy",
                    Picture = "claudy",
                    Phrases = new List<Phrase>()
                        {
                            new Phrase()
                            {
                                Sound = "alien",
                                Name = "Faut faire refaire hein ! Alien !",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "boitagant",
                                Name = "La boîte à gants",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "ca_va_suffir",
                                Name = "Ça va suffire, maint'nant !",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "carjacker",
                                Name = "Je viens d'me faire carjacker",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "cheval_truie_tronche",
                                Name = "T'as vu ta tronche, ou quoi ?",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "chips",
                                Name = "Chips",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "claudy_focan",
                                Name = "Je suis claudy focan",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "cochon_electrique",
                                Name = "C'est un vrai ? Non c'est un électrique",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "connasse_va",
                                Name = "Connasse, va !",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "couilles",
                                Name = "Pas commencer à jouer avec mes couilles !",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "epilee_copine",
                                Name = "T'es épilée, t'es pas épilée",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "frein_a_main",
                                Name = "T'es épais comme un câble de frein à main",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "je_rame",
                                Name = "Je rame",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "jte_sors",
                                Name = "Ou tu sors ou j'te sors",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "la_meme",
                                Name = "La même ?",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "mal_baisee",
                                Name = "Mal baisée, va !",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "mal_reveillee",
                                Name = "T'as mal dormi ?",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "michael_jackson_13sec",
                                Name = "Michael Jackson",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "mousse_savon",
                                Name = "Y goûte le savon",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "oui_tendu",
                                Name = "Oui, claudy, je suis tendu",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "pas_de_tutututu",
                                Name = "Pas de tutututu",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "poney",
                                Name = "J'vais aller chercher le poney",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "ptite_culotte",
                                Name = "Enlève ta p'tite culotte !",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "ptite_pute",
                                Name = "Natasha",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "quelle_violence",
                                Name = "Quelle violence",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "tchin",
                                Name = "Tchin tchin",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "tendu_crampe",
                                Name = "T'es tendue comme une crampe",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "tendu_tendu",
                                Name = "Si je te dis que t'es tendue",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "termine_bonsoir",
                                Name = "Terminé bonsoir",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "tu_ne_me_vois_pas",
                                Name = "Tu ne me vois pas ?",
                                Picture = "claudy"
                            },
                            new Phrase()
                            {
                                Sound = "vieille_truie_moyen",
                                Name = "Vieille truie",
                                Picture = "claudy"
                            },
                        }
                };
                #endregion claudy

                #region jc

                var jc = new Category()
                {
                    Name = "Jean-Claude",
                    Picture = "jc",
                    Phrases = new List<Phrase>()
                        {
                            new Phrase()
                            {
                                Sound = "bercee_mur",
                                Name = "Bercée trop près du mur",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "bonjour_sabine",
                                Name = "Dis bonjour Sabine !",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "cracher_lama",
                                Name = "Cracher partout comme un lama",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "encore_une_petite",
                                Name = "Encore une petite ?",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "excessivement_enervant",
                                Name = "Excessivement énervant",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "excuse_toi",
                                Name = "Excuse toi tout d'suite !",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "fou_ce_type",
                                Name = "Il est tout à fait fou ce type !",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "gang_bang",
                                Name = "Gang bang",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "jplais_pas",
                                Name = "Je sais que j'plais pas à tout l'monde",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "les_3_coups",
                                Name = "Les 3 coups",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "moches",
                                Name = "Se taper une moche",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "negocier_nichons",
                                Name = "Négocier avec ses nichons",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "tete_originale",
                                Name = "Ta tête est déjà originale",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "tomber_sus",
                                Name = "Ca s'appelle tomber de son sus",
                                Picture = "jc"
                            },
                            new Phrase()
                            {
                                Sound = "trou_de_balle",
                                Name = "Tourner autour du trou de balle",
                                Picture = "jc"
                            },
                        }
                };
                #endregion jc

                #region nadine

                var nadine = new Category()
                {
                    Name = "Nadine",
                    Picture = "nadine",
                    Phrases = new List<Phrase>()
                        {
                            new Phrase()
                            {
                                Sound = "candie",
                                Name = "Ressemble plus à Albator qu'à candy",
                                Picture = "nadine"
                            },
                            new Phrase()
                            {
                                Sound = "clic_mieux_claque",
                                Name = "Un p'tit clic vaut mieux qu'une grande claque !",
                                Picture = "nadine"
                            },
                            new Phrase()
                            {
                                Sound = "morte_maitresse",
                                Name = "Elle est morte la maitresse !",
                                Picture = "nadine"
                            },
                            new Phrase()
                            {
                                Sound = "moteur",
                                Name = "Le moteur, c'est pas devant ?",
                                Picture = "nadine"
                            },
                            new Phrase()
                            {
                                Sound = "schnouf_fleau",
                                Name = "La schnouf c'est un fléau",
                                Picture = "nadine"
                            },
                            new Phrase()
                            {
                                Sound = "touche_seins",
                                Name = "Je ne supporte pas qu'on me touche les seins",
                                Picture = "nadine"
                            },
                        }
                };
                #endregion nadine

                Categories.Add("claudy", claudy);
                Categories.Add("jc", jc);
                Categories.Add("nadine", nadine);
                Categories.Add("others", others);

                IsDataLoaded = true;
            }
        }

    }
}