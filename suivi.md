# Suivi des activités

## 31.1

- Feedback XCL
    - Le contrat est OK, il ne reste qu'à en faire une version pdf signée et la mettre dans le repo
    - Commencez à coder la bataille navale

- journal de travail
    - 25 minutes :Quelques explications du prof
    - 10 minutes : Imprimer le contrat de travail pour le projet : 10 minutes
    - 145 minutes :Coder le menu de démarrage de la bataille naval (Faire le code du titre, mettre en place des boucles qui demande au joueur combient de case aura le jeu + mettre les erreurs)

## 7.2
- Feedback XCL
    - Mettez votre code dans le repo Git, que je puisse y avoir accès
    - Pour le journal: détaillez plus. 145 minutes sans commentaires, c'est long
 
- journal de travail
    - 100 minutes : commencer la grille du plateau de jeu (inspiration de ma grille de puissance 4 et aide de Jonathan Junod)
    - 35 minutes : recherche dans les fichers de prog comment faire une grille de plateau de jeu

## 14.2
- Feedback XCL
    - Mettez votre code dans le repo Git, que je puisse y avoir accès. Attention : je vous ai déjà demandé ça la semaine passée, ne vous loupez pas cette fois
    - Dans votre journal, mettez le résultat de vos recherches
 
- journal de travail
    - 30 minutes :finir de coder le tableau de jeu
    - 30 minutes : coder les règles du jeu
    - 30 minutes : mettre le menu dans une méthode (avec l'aide de Jonathan Junod)
    - 45 minutes : mettre la possibilité de choisir le nombre de bateau sur le plateau de jeu

## 28.2

- Feedback XCL
    - Le code est dans le repo, merci
    - Faites des commits atomiques: ne mettez pas le code ET la mise à jour de votre suivi dans le même commit: ce sont deux choses différentes qui doivent aller dans deux commits différents
    - Ne committez pas du code qui ne compile pas. Mettez les lignes problématiques en commentaire avan de commiter.
    - Vous avez passé 45 minutes à "mettre la possibilité de choisir le nombre de bateau sur le plateau de jeu", mais je ne vois aucun code qui correspond au nombre de bateaux. 

- journal de travail
    - 30 minutes : refaire la demande des bateaux
    - 10 minutes : faire le message d'adieu quand le joueur part
    - 15 minutes : explication du prof pour le projet
    - 45 minutes : améliorer la demande pour les bateaux
    - 35 minutes : tester mon code C# et verifier que je n'ai pas fait d'erreur


## 7.3

- Feedback XCL
    - J'avais demandé de faire un bilan des objectifs, il n'a pas été fait
    - Le journal de travail est incomplet: 100 minutes alors que vous en aviez 135 à disposition
    - Nommage de commits: il est nécessaire maintenant d'améliorer ce point car il est insuffisant à ce stade

- Journal de travail
    - 50 minutes : faire une méthode, avec l'aide de jonathan, qui permet d'afficher les cases qui sont dans l'eau et les cases où il y a des bateaux
    - 10 minutes : faire le status.md 
    - 45 minutes essayer de corriger l'erreur avec le curseur dans le jeu
    - 30 minutes tester le code C# que tout fonctionne bien

    
## 14.3

- Feedback XCL
    - Il y a deux dossiers "bataille nava..." dans votre repo. Il faut n'en garder qu'un.
    - Les progrès du code de la semaine passée sont spectaculaires. J'aimerais en parler avec vous, car à la lecture de votre journal et de vos commits, je ne parviens pas à comprendre comment vous en êtes arrivé là.
    - Jdt OK

- Journal de travail
    - 30 minutes : explication du prof
    - 45 minutes : trouver l'erreur du curseur
    - 15 minutes : mettre les variables pour les bateaux
    - 45 minutes : tester mon code pour voir les problème, style le curseur ou les bateaux
 
# Conclusion

Le résultat est plutôt bon. L'interface utilisateur est agréable, dommage que le problème de curseur n'ait pas été résolu. Je n'arrive pas à déplacer le curseur avec précision : le déplacement répond toujours à une touche précédente. De plus, au moment de tirer, la case atteinte par mon tir n'est pas celle où se trouve le curseur.

Du coup, je suis assez surpris de voir dans votre journal "trouver l'erreur du curseur". Il ne me semble pas que vous l'avez trouvée. De plus, on ne peut pas dire que l'objectif "le joueur doit pouvoir tirer dans les cases du plateau de jeu" est atteint puisque les tirs n'arrivent pas là où je veux.

Il y a un point qui me dérange particulièrement : vous avez modifié un objectif en cours de route. Dans votre statut, vous dites que vous avez atteint l'objectif "le code doit pouvoir afficher les bateaux qui sont touché et les cases vide". Cela est correct. Ce qui ne va pas, c'est que l'objectif dans le contrat que nous avons signé disait "le code doit pouvoir afficher les bateaux qui sont touché, coulé et de marquer les cases qui sont touchées dans l'eau". Ce n'est pas le cas : les bateaux coulés ne sont pas affiché comme tel.

Dans le monde professionnel qui vous attend, de tels procédés pourraient vous attirer des ennuis. Si cela avait été un vrai projet, je n'aurais pas validé.

Mais comme il s'agit d'un projet d'approfondissement, je valide car vous avez effectivement amélioré vos compétences C#
