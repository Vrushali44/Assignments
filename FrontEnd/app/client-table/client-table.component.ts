import { Component, OnInit, Input } from '@angular/core';
import { ClientServiceService} from '../client-service.service';



@Component({
  selector: 'app-client-table',
  templateUrl: './client-table.component.html',
  styleUrls: ['./client-table.component.scss']
})
export class ClientTableComponent implements OnInit {

  ClientService:any;
  @Input() resultData;

  
  constructor(private myservice:ClientServiceService) { }

  ngOnInit() {
   
  }
  
  
}
