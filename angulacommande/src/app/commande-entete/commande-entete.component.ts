import { Component, OnInit } from '@angular/core';
import { Client } from '../Model/client';
import { CommandeEntete } from '../Model/commande-entete';
import { ClientService } from '../service/client.service';
import { EnteteCmdService } from '../service/entete-cmd.service';

@Component({
  selector: 'app-commande-entete',
  templateUrl: './commande-entete.component.html',
  styleUrls: ['./commande-entete.component.css']
})
export class CommandeEnteteComponent implements OnInit {
  tabClient: Client[]=[]; 
  commandeEntete = new  CommandeEntete;

  constructor(private clientService: ClientService,private enteteCmd: EnteteCmdService) { }

  ngOnInit(): void {
    this.clientService.getAllClient()
    .subscribe((response) => {
      this.tabClient = response;
    });
  }

}
