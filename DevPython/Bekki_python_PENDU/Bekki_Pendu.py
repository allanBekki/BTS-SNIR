import random
def nettoyage_mot(mot):
    """
    Description de la fonction : met en forme un mot choisi par l'ordinateur
    mot (str) : mot comportant des caractères non souhaités (accents, majuscules, caractères retour à la ligne)
    return (str) :  mot "nettoyé" (tout en minuscule, en enlevant les accents et les retours à la ligne)
    mot = mot[:-1]
    """
    
    mot2=""
    mot = mot[:-1]
    mot.lower()
    mot = mot.replace("é","e")
    mot = mot.replace("è","e")
    mot = mot.replace("ê","e")
    mot = mot.replace("ë","e")
    
    mot = mot.replace("à","a")
    mot = mot.replace("â","a")
    mot = mot.replace("ä","a")
    
    mot = mot.replace("ô","o")
    mot = mot.replace("ö","o")
    
    mot = mot.replace("û","u")
    mot = mot.replace("ü","u")
    
    mot = mot.replace("ÿ","y")
    
    mot = mot.replace("ç","c")
   
#     for c in mot:
#         if (c == "é"or c== "è"):
#             mot2 = mot2 + "e"
#         else :
#             mot2 = mot2 + c
    return mot

def tirage_au_sort(nom_fichier):
    """
    Description de la fonction : tire au hasard un mot dans le fichier 
                                "nettoie ce mot"
                                fabrique un mot mystère composé d'autant de tirets (-) que de lettres à découvrir
    nom_fichier (str) : nom du fichier dans lequel le programme va choisir un mot
    return (tuple) : mot "nettoyé" (str), mot mystere(str)
    """
    nom_fichier="dictionnaire.txt"
    fichier = open('dictionnaire.txt','r', encoding = 'utf8')
    x=random.randrange(1 , 22275)
    
    for i in range (x):
        chaine = fichier.readline()
    fichier.close()
    
    chaine=nettoyage_mot(chaine)
    
    tailleChaine=len(chaine)
    
    motMystere=''
    for i in range (tailleChaine):
        motMystere= motMystere +'-'
    
    t = [chaine, motMystere]
    return t


def deja_choisie(lettre):
    """
    Description de la fonction : Ajoute dans LETTRES_DEJA_CHOISIES les lettres choisies par le joueur
    et affiche un message informant le joueur dans le cas où il choisit une lettre déjà proposée précédemment
    lettre (str) : lettre proposée par le joueur
    return (bool) : True si la lettre a déjà été choisié, False sinon
    MODIFICATION EN PLACE de LETTRES_DEJA_CHOISIES
    """
    global LETTRES_DEJA_CHOISIES

    if (lettre in LETTRES_DEJA_CHOISIES):
        print ("Bah frero, tu as deja utilisé cette lettre !!")
        return True
    else:
        #LETTRES_DEJA_CHOISIES= LETTRES_DEJA_CHOISIES.append(lettre)
        LETTRES_DEJA_CHOISIES= LETTRES_DEJA_CHOISIES + [lettre]
        return False
    
def jeu_fini():
    """
    Description de la fonction : Détermine si le jeu est fini
    return (bool) : True si le jeu est fini, False sinon
    """
    global SCORE
    global MOT_MYSTERE
    
    if (SCORE==0 or MOT_MYSTERE == MOT_A_DECOUVRIR):
        return True
    else:
        return False
    
def afficher_bilan():
    """
    Description de la fonction : Affiche les "messages bilans" en fin de partie (voir copie d'écran dans l'énoncé)
    return (None)
    """
    global SCORE
    global MOT_A_DECOUVRIR
    
    if (SCORE == 0):
        print("Vous avez perdu, le mot a decouvrir etait: ",MOT_A_DECOUVRIR)
    elif (MOT_A_DECOUVRIR == MOT_MYSTERE):
        print ("Vous decouvert le mot : ",MOT_A_DECOUVRIR)
        
    return None

    

def remplace_tiret(lettre):
    """
    Description de la fonction : Remplace le/les '-' par la lettre si
    lettre (str) : une lettre proposée par le joueur
    return (bool) : True si le joueur à trouver une nouvelle lettre, False sinon
    MODIFICATION DE MOT_MYSTERE
    """
    global MOT_MYSTERE
    global MOT_A_DECOUVRIR
    res= False
    for i in range (len(MOT_A_DECOUVRIR)):
        if (MOT_A_DECOUVRIR[i] == lettre):
            MOT_MYSTERE = MOT_MYSTERE[0 : i] + lettre + MOT_MYSTERE[i+1:]
            res= True
    return res
        
        #ms= ms[0 , i] + lettre +  ms[i]
        
def jouer():
    """
    Description de la fonction : Permet de jouer au jeu du pendu
    return : None
    """
    global MOT_A_DECOUVRIR
    global MOT_MYSTERE
    global SCORE
    global LETTRES_DEJA_CHOISIES
    SCORE = 8
    LETTRES_DEJA_CHOISIES=[]
    (MOT_A_DECOUVRIR , MOT_MYSTERE) = tirage_au_sort("dictionnaire.txt")
    print ("=============================") 
    print ("BIENVENUE AU JEU DU PENDU !!!")
    print ("=============================")
    #print (MOT_A_DECOUVRIR)
    while( not jeu_fini()):
        lettre= input("Donnez moi une lettre : ")
        while deja_choisie(lettre):
            lettre= input("Donnez moi une lettre : ")
        if remplace_tiret(lettre) == True:
            SCORE=SCORE-1
        print(MOT_MYSTERE)
    afficher_bilan()
    
    
