import { Component, OnInit } from '@angular/core';
import { Client } from '../../Model/client';
import { ClientService } from '../../service/client.service';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {
  tabClient: Client[] = [];

  constructor(private clientService: ClientService) { }

  ngOnInit(): void {
    //this.tabClient = this.clientService.getAllClient();
    this.clientService.getAllClient()
    .subscribe((response) => {
      this.tabClient = response;
      console.log(response)
    });
  }

}
