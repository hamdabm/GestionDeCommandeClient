import { Component, OnInit } from '@angular/core';
import { Client } from '../../Model/client';
import { ClientService } from '../../service/client.service';

@Component({
  selector: 'app-add-client',
  templateUrl: './add-client.component.html',
  styleUrls: ['./add-client.component.css']
})
export class AddClientComponent implements OnInit {
  client = new Client;

  constructor(private clientService: ClientService) { }

  ngOnInit(): void {
  }

  save (){
    console.log(this.client)
    this.clientService.addClient(this.client).subscribe(
      response => {
        console.log(response);
      }
    )
  }

}
