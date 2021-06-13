import { Client } from "./client";
import { CommandeLigne } from "./commande-ligne";

export class CommandeEntete {
    
    number=0;
    dateCmd: string="";
    numeroCmd: string="";
    montantTot: number=0;
    client: Client=new Client;
    idClt: number=0;
    commandeLignes: CommandeLigne[]=[];

}

