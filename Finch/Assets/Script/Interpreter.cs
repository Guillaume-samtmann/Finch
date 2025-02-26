using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();
    bool isAdmin = false;
    bool teteIsinstall = false;
    bool brasRisinstall = false;
    bool mainRisinstall = false;
    bool jambeRisinstall = false;
    bool piedRisinstall = false;
    bool brasGisinstall = false;
    bool mainGisinstall = false;
    bool jambeGisinstall = false;
    bool piedGisinstall = false;
    bool isConnecter = true;
    bool teteIsConf = false;
    bool brasRisConf = false;
    bool mainRisConf = false;
    bool jambeRisConf = false;
    bool piedRisConf = false;
    bool brasGisConf = false;
    bool mainGisConf = false;
    bool jambeGisConf = false;
    bool piedGisConf = false;
    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        if (args[0] == "help")
        {
            //Return some info
            response.Add("If you want to use the terminal, type \"boop\" ");
            response.Add("This is the second line that we are returning");

            return response;
        }
        //sudo su
        if (string.Join(" ", args) == "sudo su")
        {
            if(isAdmin)
            {
                response.Add("Vous etes d�ja connectez");
                return response;
            }
            else
            {
                response.Add("Vous etes connectez � l'interface de d�veloppement");
                isAdmin = true;
                isConnecter = true;
                return response;
            }
        }
        //exit
        if (args[0] == "exit")
        {
            if(isConnecter)
            {
                response.Add("Vous �tes d�connectez press \"E\" pour sortir de l'ordinateur");
                isAdmin = false;
                isConnecter = false;
                return response;
            }
            else
            {
                response.Add("Vous �tes d�ja d�onnectez");
                return response;
            }
            
        }
        //Install Tete
        if(string.Join(" ", args) == "sudo apt install tete")
        {
            if(isAdmin)
            {
                if (PlayerPrefs.HasKey("Tete_Position") && PlayerPrefs.HasKey("Tete_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (!teteIsinstall)
                    {
                        response.Add("Le package \"tete\" est bien install� vous pouvez le configurez");
                        teteIsinstall = true;
                        return response;
                    }
                    else
                    {
                        response.Add("Package d�ja install�");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Config Tete
        if (string.Join(" ", args) == "cat tete_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("Tete_Position") && PlayerPrefs.HasKey("Tete_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (teteIsinstall)
                    {
                        if (!teteIsConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez la t�te au robot");
                            PlayerPrefs.SetInt("TeteIsConfig", 1);
                            PlayerPrefs.Save();
                            teteIsConf = true;
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � t�te dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Install brasR
        if (string.Join(" ", args) == "sudo apt install brasR")
        {
            if(isAdmin)
            {
                if (PlayerPrefs.HasKey("BrasR_Position") && PlayerPrefs.HasKey("BrasR_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (!brasRisinstall)
                    {
                        response.Add("Le package \"brasR\" est bien install� vous pouvez le configurez");
                        brasRisinstall = true;
                        return response;
                    }
                    else
                    {
                        response.Add("Package d�ja install�");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }

        }
        //Config BrasR
        if (string.Join(" ", args) == "cat brasR_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("BrasR_Position") && PlayerPrefs.HasKey("BrasR_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (brasRisinstall)
                    {
                        if (!brasRisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez le bras (r�f : 982374) au robot");
                            brasRisConf = true;
                            PlayerPrefs.SetInt("BrasRIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence au brasR dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Install mainR
        if (string.Join(" ", args) == "sudo apt install mainR")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("MainR_Position") && PlayerPrefs.HasKey("MainR_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (PlayerPrefs.HasKey("BrasR_Position") && PlayerPrefs.HasKey("BrasR_Rotation"))
                    {
                        if (!mainRisinstall)
                        {
                            response.Add("Le package \"mainR\" est bien install� vous pouvez le configurez");
                            mainRisinstall = true;
                            return response;
                        }
                        else
                        {
                            response.Add("Package d�ja install�");
                            return response;
                        }
                    }
                    else
                    {
                        if (brasRisConf)
                        {
                            if (!mainRisinstall)
                            {
                                response.Add("Le package \"mainR\" est bien install� vous pouvez le configurez");
                                mainRisinstall = true;
                                return response;
                            }
                            else
                            {
                                response.Add("Package d�ja install�");
                                return response;
                            }

                        }
                        else
                        {
                            response.Add("Erreur il manque des d�pendances");
                            return response;
                        }
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Config MainR
        if (string.Join(" ", args) == "cat mainR_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("MainR_Position") && PlayerPrefs.HasKey("MainR_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (mainRisinstall)
                    {
                        if (!mainRisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez la main (r�f : 981985) au robot");
                            mainRisConf = true;
                            PlayerPrefs.SetInt("MainRIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � mainR dans vos package la config est impossible");
                        return response;
                    }
                }   
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Install jambeR
        if (string.Join(" ", args) == "sudo apt install jambeR")
        {
            if(isAdmin)
            {
                if (PlayerPrefs.HasKey("JambeR_Position") && PlayerPrefs.HasKey("JambeR_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (!jambeRisinstall)
                    {
                        response.Add("Le package \"jambeR\" est bien install� vous pouvez le configurez");
                        jambeRisinstall = true;
                        return response;
                    }
                    else
                    {
                        response.Add("Package d�ja install�");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Config JambeR
        if (string.Join(" ", args) == "cat jambeR_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("JambeR_Position") && PlayerPrefs.HasKey("JambeR_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (jambeRisinstall)
                    {
                        if (!jambeRisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez la jambe (r�f : 984876) au robot");
                            jambeRisConf = true;
                            PlayerPrefs.SetInt("JambeRIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � jambeR dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }
        }
        //Install piedR
        if (string.Join(" ", args) == "sudo apt install piedR")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("PiedR_Position") && PlayerPrefs.HasKey("PiedR_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (PlayerPrefs.HasKey("JambeR_Position") && PlayerPrefs.HasKey("JambeR_Rotation"))
                    {
                        if (!piedRisinstall)
                        {
                            response.Add("Le package \"piedR\" est bien install� vous pouvez le configurez");
                            piedRisinstall = true;
                            return response;
                        }
                        else
                        {
                            response.Add("Package d�ja install�");
                            return response;
                        }
                    }
                    else
                    {
                        if (jambeRisConf)
                        {
                            if (!piedRisinstall)
                            {
                                response.Add("Le package \"piedR\" est bien install� vous pouvez le configurez");
                                piedRisinstall = true;
                                return response;
                            }
                            else
                            {
                                response.Add("Package d�ja install�");
                                return response;
                            }
                        }
                        else
                        {
                            response.Add("Erreur il manque des d�pendances");
                            return response;
                        }
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }
        }
        //Config PiedR
        if (string.Join(" ", args) == "cat piedR_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("PiedR_Position") && PlayerPrefs.HasKey("PiedR_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (piedRisinstall)
                    {
                        if (!piedRisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez le pied (r�f : 9805542) au robot");
                            piedRisConf = true;
                            PlayerPrefs.SetInt("PiedsRIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � piedR dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }
        }
        //Install brasG
        if (string.Join(" ", args) == "sudo apt install brasG")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("BrasG_Position") && PlayerPrefs.HasKey("BrasG_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (!brasGisinstall)
                    {
                        response.Add("Le package \"brasG\" est bien install� vous pouvez le configurez");
                        brasGisinstall = true;
                        return response;
                    }
                    else
                    {
                        response.Add("Package d�ja install�");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }

        }
        //Config BrasG
        if (string.Join(" ", args) == "cat brasG_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("BrasG_Position") && PlayerPrefs.HasKey("BrasG_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (brasGisinstall)
                    {
                        if (!brasGisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez le bras (r�f : 992374) au robot");
                            brasGisConf = true;
                            PlayerPrefs.SetInt("BrasGIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � brasG dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }
        }
        //Install mainG
        if (string.Join(" ", args) == "sudo apt install mainG")
        {
            if(isAdmin)
            {
                if (PlayerPrefs.HasKey("MainG_Position") && PlayerPrefs.HasKey("MainG_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (PlayerPrefs.HasKey("BrasG_Position") && PlayerPrefs.HasKey("BrasG_Rotation"))
                    {
                        if (!mainGisinstall)
                        {
                            response.Add("Le package \"mainG\" est bien install� vous pouvez le configurez");
                            mainGisinstall = true;
                            return response;
                        }
                        else
                        {
                            response.Add("Package d�ja install�");
                            return response;
                        }
                    }
                    else
                    {
                        if (brasGisConf)
                        {
                            if (!mainGisinstall)
                            {
                                response.Add("Le package \"mainG\" est bien install� vous pouvez le configurez");
                                mainGisinstall = true;
                                return response;
                            }
                            else
                            {
                                response.Add("Package d�ja install�");
                                return response;
                            }
                        }
                        else
                        {
                            response.Add("Erreur il manque des d�pendances");
                            return response;
                        }
                    }

                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        //Config MainG
        if (string.Join(" ", args) == "cat mainG_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("MainG_Position") && PlayerPrefs.HasKey("MainG_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (mainGisinstall)
                    {
                        if (!mainGisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez la main (r�f : 991985) au robot");
                            mainGisConf = true;
                            PlayerPrefs.SetInt("MainGIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;

                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � mainG dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }

        }
        //Install jambeG
        if (string.Join(" ", args) == "sudo apt install jambeG")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("JambeL_Position") && PlayerPrefs.HasKey("JambeL_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (!jambeGisinstall)
                    {
                        response.Add("Le package \"jambeG\" est bien install� vous pouvez le configurez");
                        jambeGisinstall = true;
                        return response;
                    }
                    else
                    {
                        response.Add("Package d�ja install�");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }
        }
        //Config JambeG
        if (string.Join(" ", args) == "cat jambeG_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("JambeL_Position") && PlayerPrefs.HasKey("JambeL_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else
                {
                    if (jambeGisinstall)
                    {
                        if (!jambeGisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez la jambe (r�f : 994876) au robot");
                            jambeGisConf = true;
                            PlayerPrefs.SetInt("JambeGIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }

                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � jambeG dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");

                return response;
            }
        }
        //Install piedG
        if (string.Join(" ", args) == "sudo apt install piedG")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("PiedL_Position") && PlayerPrefs.HasKey("PiedL_Rotation"))
                {
                    response.Add("Package d�ja install�");
                    return response;
                }
                else
                {
                    if (PlayerPrefs.HasKey("JambeL_Position") && PlayerPrefs.HasKey("JambeL_Rotation"))
                    {
                        if (!piedGisinstall)
                        {
                            response.Add("Le package \"piedG\" est bien install� vous pouvez le configurez");
                            piedGisinstall = true;
                            return response;
                        }
                        else
                        {
                            response.Add("Package d�ja install�");
                            return response;
                        }
                    }
                    else
                    {
                        if (jambeGisConf)
                        {
                            if (!piedGisinstall)
                            {
                                response.Add("Le package \"piedG\" est bien install� vous pouvez le configurez");
                                piedGisinstall = true;
                                return response;
                            }
                            else
                            {
                                response.Add("Package d�ja install�");
                                return response;
                            }
                        }
                        else
                        {
                            response.Add("Erreur il manque des d�pendances");
                            return response;
                        }
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }

        }
        //Config PiedG
        if (string.Join(" ", args) == "cat piedG_config.txt")
        {
            if (isAdmin)
            {
                if (PlayerPrefs.HasKey("PiedL_Position") && PlayerPrefs.HasKey("PiedL_Rotation"))
                {
                    response.Add("Configuration d�ja en place");
                    return response;
                }
                else 
                {
                    if (piedGisinstall)
                    {
                        if (!piedGisConf)
                        {
                            response.Add("Fichiez cr�e vous pouvez ajoutez le pied (r�f : 9905542) au robot");
                            piedGisConf = true;
                            PlayerPrefs.SetInt("PiedGIsConfig", 1);
                            PlayerPrefs.Save();
                            return response;
                        }
                        else
                        {
                            response.Add("Configuration d�ja en place");
                            return response;
                        }
                    }
                    else
                    {
                        response.Add("Aucune r�f�rence � piedG dans vos package la config est impossible");
                        return response;
                    }
                }
            }
            else
            {
                response.Add("Vous n'avez pas les droits n�cessaire");
                return response;
            }
        }
        else
        {
            response.Add("Command not recognized.");
            return response;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !isConnecter)
        {
            SceneManager.LoadScene(0);
        }
    }
}


