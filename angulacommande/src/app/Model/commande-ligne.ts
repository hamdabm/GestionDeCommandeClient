import { CommandeEntete } from "./commande-entete";
import { Produit } from "./produit";

export class CommandeLigne {
    idCmdLigne: number=0;
    prixProd: number=0;
    dateLigne: string="";
    qteLigne: number=0;
    idCmdEnt: number=0;
    commandeEntete: CommandeEntete = new CommandeEntete;
    produit: Produit = new Produit;
    idProd: number=0;

}
