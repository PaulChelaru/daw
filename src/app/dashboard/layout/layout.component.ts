import { Component, OnInit } from '@angular/core';
import { ClientService } from 'src/app/services/client.service';
@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  constructor(private clientService: ClientService) { }

  ngOnInit(): void {
    // console.log(this.clientService.getAllClients())
  }

}
