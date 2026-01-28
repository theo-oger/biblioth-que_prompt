using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PromptLibrary_Modele;
using PromptLibrary_Modele.TableRef;

namespace PromptLibrary_DAL
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var ctx = new PromptLibraryContext(serviceProvider.GetRequiredService<DbContextOptions<PromptLibraryContext>>());
            bool isAdded = false;

            #region Framework

            Dictionary<int, Framework> frameworks = new() {
                { 1 ,new() { Nom = "APE", Description = "Le framework APE (Action, Purpose, Expectation) convient à de nombreux cas d’usage, notamment la création de contenu, la planification stratégique et les outils de formation. Il est particulièrement utile pour les projets nécessitant des informations détaillées.", Contenu = "Action : [décrire précisément la tâche ou l’action attendue de l’IA, de façon spécifique et concrète].\r\n\r\nObjectif : Mon but est de [expliquer les raisons qui motivent cette demande, le contexte ou les enjeux sous-jacents].\r\n\r\nAttentes : La réponse doit [préciser le format souhaité, les éléments clés à inclure ou les critères de satisfactions].\r\n"}},
                { 2 ,new() { Nom = "BAB", Description = "Le framework BAB (Before After Bridge) est particulièrement adapté à l’élaboration de stratégies et à la résolution de problèmes. Il permet de clarifier une situation initiale, de définir un objectif précis et de guider l’IA vers les étapes nécessaires pour passer de l’un à l’autre.", Contenu = "Avant : [Décrire la situation avant le changement souhaité]\r\n\r\nAprès : [Indiquer le résultat attendu ou l’état final]\r\n\r\nPont : [Demander à l’IA de fournir le pont entre “avant” et “après”]\r\n" }},
                { 3 ,new() { Nom = "CARE", Description = "Le framework CARE (Context, Action, Result, Example) est utile dans les cas où des conseils détaillés, des résultats pratiques et des exemples concrets peuvent améliorer de manière significative l’efficacité et la pertinence du contenu généré par l’IA. Il est donc parfaitement adapté aux scénarios nécessitant une planification stratégique.", Contenu = "Contexte : [décrire la situation globale, l’environnement ou les circonstances dans lesquelles s’inscrit la demande.]\r\n\r\nAction : [préciser la tâche spécifique, l’analyse à mener ou l’action concrète attendue de l’IA.]\r\n\r\nRésultat : [définir le livrable souhaité, l’objectif mesurable ou le bénéfice attendu de l’action de l’IA.]\r\n\r\nExemple : [fournir une illustration concrète, un cas d’usage ou un scénario de réussite pour guider la réponse de l’IA.]\r\n" }},
                { 4 ,new() { Nom = "CIDI", Description = "Le framework CIDI (Context, Instructions, Details, Input) permet d’obtenir des réponses précises. Il est particulièrement utile pour générer du contenu détaillé, planifier des stratégies ou développer des formations.\r\n", Contenu = "Contexte : Vous êtes [définir le rôle de l’IA]\r\n\r\nInstructions : [Tâche]\r\n\r\nDétails : [préciser les éléments clés à inclure]\r\n\r\nDonnées d’entrée :\r\n\r\n[Informations utiles 1]\r\n[Informations utiles 2]\r\n[Informations utiles 3]\r\n" }},
                { 5 ,new() { Nom = "COAST", Description = "Le framework COAST (Context, Objective, Actions, Scenario, Task) est particulièrement adapté aux projets nécessitant une planification détaillée, notamment la création de contenu et la planification stratégique.", Contenu = "Contexte : [décrire le contexte général, l’environnement ou le cadre dans lequel s’inscrit la demande.]\r\n\r\nObjectif : Le but est de [clarifier ce que l’on cherche à accomplir ou le résultat global souhaité].\r\n\r\nActions : Pour atteindre cet objectif, il faudra [lister les actions clés, les démarches ou les réflexions à mener].\r\n\r\nScénario : Prenons l’exemple concret suivant : [détailler une situation spécifique, un cas d’usage ou un défi illustrant le besoin].\r\n\r\nTâche : Je vous demande de [préciser le livrable attendu, le format de restitution ou les éléments à fournir].\r\n" }},
                { 6 ,new() { Nom = "COSTAR", Description = "Le framework COSTAR (Context, Outcome, Scale, Time, Actor, Resources) est particulièrement adapté pour définir des objectifs clairs et structurés dans divers domaines. Il permet de décomposer un objectif en différents éléments essentiels.", Contenu = "Contexte : [décrire l’environnement, les circonstances, le cadre de l’objectif]\r\n\r\nRésultat : [définir clairement le résultat final souhaité]\r\n\r\nÉchelle : [préciser l’ampleur et la portée visée pour le résultat]\r\n\r\nTemps : [établir un calendrier, des délais, une date butoir]\r\n\r\nActeur : [nommer l’individu, l’équipe ou le service responsable des actions]\r\n\r\nRessources : [lister les moyens, outils, budget, informations, soutiens nécessaires]\r\n" }},
                { 7 ,new() { Nom = "ERA", Description = "Le framework ERA (Expectation, Role, Action) est adapté à une grande variété de cas d’usage, en particulier lorsqu’il s’agit de générer des réponses détaillées. Il est utile pour des tâches allant de la génération d’idées à la planification stratégique.", Contenu = "Attente : [Décrire de façon concise le résultat souhaité ou l’objectif à atteindre]\r\n\r\nRôle : [Spécifier le rôle, la posture ou le domaine d’expertise attendu de l’IA]\r\n\r\nAction : [Lister les actions concrètes et les livrables attendus de l’IA]\r\n" }},
                { 8 ,new() { Nom = "FAB", Description = "Le framework FAB (Features, Advantages, Benefits) offre une approche simple et efficace qui met l’accent sur la présentation des caractéristiques d’un produit ou d’un service, des avantages qu’il offre et des bénéfices que les utilisateurs peuvent en attendre. Ce framework vous permet de communiquer clairement la valeur de votre offre à votre public cible.", Contenu = "Informations sur le [produit/service] [nom] :\r\n\r\nFonctionnalités principales : [liste des fonctionnalités]\r\nAvantages de chaque fonctionnalité : [liste des avantages]\r\nBénéfices pour les utilisateurs : [liste des bénéfices]\r\n\r\nPublic cible : [décrire le public]\r\n\r\nEn te basant sur ces éléments, rédige [type de contenu demandé] d’environ [nombre de mots] mots pour promouvoir efficacement ce [produit/service] auprès de notre cible ?\r\n" }},
                { 9 ,new() { Nom = "FOCUS", Description = "Le framework FOCUS (Function, Objective, Context, Utility, Specifications) est utile pour un large éventail d’applications, de la création de contenu à la planification stratégique. Son approche structurée garantit que les prompts sont formulés avec une énonciation claire de la fonction, de l’objectif, du contexte, de l’utilité et des spécifications souhaitées.\r\n", Contenu = "Fonction : Votre tâche est de [préciser la tâche, le rôle ou la mission de l’IA].\r\n\r\nObjectif : La réponse devra [indiquer clairement le but à atteindre ou le résultat visé].\r\n\r\nContexte : Pour bien comprendre le cadre, sachez que [donner les éléments de contexte pertinents comme la situation, les enjeux, les contraintes].\r\n\r\nUtilité : Ce travail servira à [expliquer l’usage qui sera fait de la réponse, par qui et dans quel but].\r\n\r\nSpécifications : Veillez à ce que la réponse respecte les critères suivants : [lister les exigences de forme].\r\n" }},
                {10 ,new(){Nom = "RACE", Description = "Le framework RACE (Reach, Act, Convert, Engage) est utile pour les cas allant de l’optimisation des stratégies pour les réseaux sociaux au lancement de campagnes de marketing ciblées. Son approche structurée garantit que le contenu et les interactions générés par l’IA ne sont pas seulement alignés sur les objectifs stratégiques, mais qu’ils sont également conçus pour maximiser l’engagement et la conversion du public.", Contenu = "Portée : Vous êtes chargé de [préciser périmètre et type d’audience]\r\n\r\nAction : Pour toucher cette audience, je vous demande de [indiquer l’action spécifique à réaliser par l’IA, en lien avec les besoins du public cible].\r\n\r\nConversion : L’objectif est de [définir l’action ou le comportement souhaité suite à l’interaction avec le contenu généré par l’IA].\r\n\r\nEngagement : Proposer des tactiques d’engagement innovantes qui [expliquer comment susciter l’intérêt, favoriser l’interaction et créer une relation avec l’audience].\r\n"}},
                {11, new(){Nom = "RELIC", Description = "Le framework RELIC (Role, Emphasis, Limitation, Information, Challenge) offre une approche sous forme de challenge, particulièrement utile pour générer des idées créatives ou planifier des événements sur un laps de temps donné.", Contenu ="Rôle : Tu es un [rôle].\r\n\r\nAccent : Mets l’accent sur [aspects clés]\r\n\r\nLimites : [Respecte les contraintes suivantes : longueur, ton, sujets à éviter].\r\n\r\nInformations : [données et contexte].\r\n\r\nDéfi : Ton objectif est de [problème à résoudre ou tâche à accomplir].\r\n"}},
                {12, new(){Nom = "RISEN", Description = "Le framework RISEN (Role, Instructions, Steps, End goal, Narrowing) se distingue dans les tâches qui doivent bénéficier d’une planification et d’une exécution détaillées, tels que la gestion de projet, la création de contenu et la planification stratégique. Sa nature structurée le rend idéal pour les tâches nécessitant une approche claire, étape par étape, pour atteindre des objectifs spécifiques.", Contenu ="Rôle : [préciser le rôle, l’expertise ou le point de vue à adopter],\r\n\r\nInstructions : [donner une consigne claire sur ce que l’on attend de l’IA].\r\n\r\nÉtapes : Pour y parvenir, veuillez suivre les étapes suivantes : [lister les différentes phases, actions ou réflexions à mener, dans un ordre logique].\r\n\r\nObjectif final : Le but est de [définir le résultat concret à atteindre, l’impact souhaité ou la valeur ajoutée].\r\n\r\nLimitations : Veillez à [préciser les contraintes, restrictions ou focus spécifiques à respecter].\r\n"}},
                {13, new(){Nom = "ROSES", Description = "Le framework RODES (Role, Objective, Details, Examples, Sens check) est particulièrement adapté aux projets nécessitant un haut degré de spécificité et de clarté, tels que les contenus éducatifs et les procédures de SAV. Son approche structurée garantit que le contenu généré par l’IA répond à des normes et à des objectifs précis.", Contenu = "Rôle : En tant que [préciser votre rôle ou votre expertise], [décrire la tâche à réaliser].\r\n\r\nObjectif : Le but est de [expliquer le résultat final souhaité].\r\n\r\nDétails : [lister les éléments spécifiques à inclure, les critères à respecter ou les étapes à suivre].\r\n\r\nExemples : [donner 2 ou 3 illustrations concrètes des attendus].\r\n\r\nVérification du sens : Une fois la tâche terminée, vérifiez bien que [rappeler les principaux points à contrôler pour s’assurer de la pertinence du résultat].\r\n"}},
                {14, new(){Nom = "RTF", Description = "Le framework RTF (Role, Task, Format) est parfait pour les scénarios nécessitant des réponses ou des instructions claires et directes. Il est particulièrement efficace lorsqu’un format de réponse spécifique est souhaité. Il s’agit du prompt le plus polyvalent qui soit et qui peut être utilisé dans la plupart des cas.", Contenu = "Rôle : Vous êtes [préciser la fonction, l’expertise ou le point de vue à adopter].\r\n\r\nTâche : Votre tâche consiste à [décrire clairement la tâche, l’activité ou le sujet à traiter].\r\n\r\nFormat : Présentez votre réponse sous la forme de [indiquer la structure souhaitée comme une liste à puces, un tableau, un paragraphe, etc].\r\n"}},
                {15, new(){Nom = "SPAR", Description = "Le framework SPAR (Situation, Purpose, Action, Result) est polyvalent et trouve son utilité dans des domaines tels que l’élaboration de stratégies, la génération d’idées et la création de contenu. Son approche structurée est particulièrement bénéfique dans les scénarios nécessitant une analyse détaillée, une compréhension globale ou une exploration créative.", Contenu ="Situation : [Décrire le contexte actuel, les éléments clés à prendre en compte ou les informations de base pour l’IA.]\r\n\r\nObjectif : L’objectif est de [préciser le but global à atteindre ou la finalité de l’interaction].\r\n\r\nAction : Pour y parvenir, [indiquer clairement la tâche, l’activité ou le livrable attendu de l’IA].\r\n\r\nRésultat : Au final, la réponse devra [détailler les caractéristiques d’une réponse réussie ou les critères permettant d’évaluer son efficacité].\r\n"}},
                {16, new(){Nom = "SPEAR", Description = "Le framework SPEAR permet de structurer vos prompts et obtenir des résultats pertinents pour de nombreux usages. Grâce à une approche en 5 étapes, il vous permet de formuler des requêtes claires et précises, en expliquant le contexte et en fournissant des exemples concrets du format attendu.", Contenu = "[Décrire le problème ou la tâche à réaliser]\r\nFournir des exemples / Consignes de formatage :\r\n\r\n[Exemple 1 du format attendu]\r\n[Exemple 2 du format attendu]\r\n[Exemple 3 du format attendu]\r\n\r\n[Décrire le contexte et les enjeux]\r\n[Formuler une requête claire et précise]\r\n\r\nAffiner les prompts jusqu’à obtenir un résultat satisfaisant.\r\n"}},
                {17, new(){Nom = "TAG", Description = "Le framework TAG (Task, Action, Goal) est utile pour la planification stratégique, la génération de contenu, les tâches de résolution de problèmes et toute application où des interactions claires et ciblées avec l’IA sont souhaitées.", Contenu ="Tâche : Mon projet consiste à [décrire la tâche globale, le sujet à traiter].\r\n\r\nAction : [Préciser les actions concrètes attendues de l’IA, comme rechercher, analyser, générer, etc.].\r\n\r\nBut : [Préciser le résultat souhaité et l’impact visé].\r\n"} },
                {18, new(){Nom = "RODES", Description = "Le framework RODES (Role, Objective, Details, Examples, Sens check) est particulièrement adapté aux projets nécessitant un haut degré de spécificité et de clarté, tels que les contenus éducatifs et les procédures de SAV. Son approche structurée garantit que le contenu généré par l’IA répond à des normes et à des objectifs précis.", Contenu ="Rôle : En tant que [préciser votre rôle ou votre expertise], [décrire la tâche à réaliser].\r\n\r\nObjectif : Le but est de [expliquer le résultat final souhaité].\r\n\r\nDétails : [lister les éléments spécifiques à inclure, les critères à respecter ou les étapes à suivre].\r\n\r\nExemples : [donner 2 ou 3 illustrations concrètes des attendus].\r\n\r\nVérification du sens : Une fois la tâche terminée, vérifiez bien que [rappeler les principaux points à contrôler pour s’assurer de la pertinence du résultat].\r\n"} }
            };

            foreach (var frame in frameworks.Values)
            {
                if (!ctx.Frameworks.Any(et => et.Nom == frame.Nom))
                {
                    ctx.Frameworks.Add(frame);
                    isAdded = true;
                }
            }
            ;
            if (isAdded)
            {
                ctx.SaveChanges();
                isAdded = false;
            }

            foreach (var frame in frameworks)
            {
                frameworks[frame.Key] = ctx.Frameworks.Single(et => et.Nom == frame.Value.Nom);
            }
            #endregion

            #region Catégories

            Dictionary<int, Categorie> categories = new() {
                { 1 ,new() { Nom = "DEV", Description = "frsrgtdgfzfg" }},
                { 2 ,new() { Nom = "GDP", Description = "dgdgdtgt" }},
                { 3 ,new() { Nom = "UI-UX", Description = "fhyhfhfyh" }},
                { 4 ,new() { Nom = "Transverse", Description = "hfthfhfht" }}
            };

            foreach (var categorie in categories.Values)
            {
                if (!ctx.Categories.Any(et => et.Nom == categorie.Nom))
                {
                    ctx.Categories.Add(categorie);
                    isAdded = true;
                }
            }
            ;
            if (isAdded)
            {
                ctx.SaveChanges();
                isAdded = false;
            }

            foreach (var categorie in categories)
            {
                categories[categorie.Key] = ctx.Categories.Single(et => et.Nom == categorie.Value.Nom);
            }
            #endregion

            #region Sous Catégories

            Dictionary<int, SubCategorie> subcategories = new() {
                { 1 ,new() { Nom = "SPFX", Description = "frfsgfrsdg" }},
                { 2 ,new() { Nom = "Csharp", Description = "frdgdgdrg" }}
            };

            foreach (var subcategorie in subcategories.Values)
            {
                if (!ctx.SubCategories.Any(et => et.Nom == subcategorie.Nom))
                {
                    ctx.SubCategories.Add(subcategorie);
                    isAdded = true;
                }
            }
            ;
            if (isAdded)
            {
                ctx.SaveChanges();
                isAdded = false;
            }

            foreach (var subcategorie in subcategories)
            {
                subcategories[subcategorie.Key] = ctx.SubCategories.Single(et => et.Nom == subcategorie.Value.Nom);
            }
            #endregion

            #region Prompt

            Dictionary<int, Prompt> prompts = new() {
                { 1 ,new() { Titre = "Génération méthode sendMail SPFX 1.14.0", CategorieId = categories[1].Id, SubCategorieId = subcategories[1].Id, FrameworkId = frameworks[1].Id, Content = "<Rôle>\r\nAgis comme un développeur d'applications spécialiste Sharepoint Online et du framework SPFX. Tu es expert dans ce domaine.\r\n</Rôle>\r\n\r\n<Contexte>\r\nJe suis développeur de sites Sharepoint Online. Je travaille sur un projet de site qui nécessite la création d'une webpart contenant un bouton déclenchant un envoi de mail.\r\n</Contexte>\r\n\r\n<Tâche>\r\nEcris moi une méthode générique permettant d'envoyer un email.\r\nCette méthode prend en paramètre un objet contenant :\r\n - l'adresse mail des destinataires\r\n - l'adresse mail des destinataires en copie\r\n - l'objet du mail\r\n - le corps de texte du mail\r\n \r\nElle est utilisable directement dans le code du fichier .tsx de ma webpart.\r\n</Tâche>\r\n\r\n<Attentes>\r\nPrésente moi le résultat au sein d'une classe avec tous les imports nécessaires.\r\nCette classe s'appelle MailTools.\r\nLa méthode d'envoi de mail s'appelle SendMail.\r\nCela doit être compatible avec la version 1.14.0 du framework SPFX et la version 2.2 de pnp/graph\r\n</Attentes>\r\n\r\n<Exemple>\r\n</Exemple>"  }},
                { 2 ,new() { Titre = "Benchmark webpart", CategorieId = categories[1].Id, SubCategorieId = subcategories[1].Id, Content = "<Rôle>\r\nAgis comme un expert en personnalisation de sites SharePoint Online et code SPFX.\r\n</Rôle>\r\n\r\n<Contexte>\r\nJe travaille dans un service spécialisé dans le développement d'applications informatique.\r\nNous travaillons notamment sur la création de sites SharePoint Online et nous développons parfois nos propres Webparts et extensions SPFX.\r\nJe souhaite utiliser une webpart/entensions qui XXX.\r\n</Contexte>\r\n\r\n<Tâche>\r\nListe moi les webparts ou extensions disponibles clés en main qui pourraient m'intéresser.\r\n</Tâche>\r\n\r\n<Attentes>\r\nMentionne également tes sources en me partageant leurs liens urls.\r\n</Attentes>\r\n\r\n" }}
            };

            foreach (var etat in prompts.Values)
            {
                if (!ctx.Prompts.Any(et => et.Titre == etat.Titre))
                {
                    ctx.Prompts.Add(etat);
                    isAdded = true;
                }
            }
            ;
            if (isAdded)
            {
                ctx.SaveChanges();
                isAdded = false;
            }

            foreach (var prompt in prompts)
            {
                prompts[prompt.Key] = ctx.Prompts.Single(et => et.Titre == prompt.Value.Titre);
            }
            #endregion

        }
    }
}
