import { Component, OnInit } from '@angular/core';
import { ClientModel } from '../client-model';
import { FormsModule } from '@angular/forms';

import { ClientServiceService } from '../client-service.service';

@Component({
  selector: 'app-form-client',
  templateUrl: './form-client.component.html',
  styleUrls: ['./form-client.component.scss']
})
export class FormClientComponent implements OnInit {

result=new ClientModel();
resultData=[];

  constructor(private myservice:ClientServiceService) { }

  ngOnInit() {
  }
  SearchClient(){
    this.myservice.
    SearchClient(this.result)
    .subscribe(v=>{ this.resultData=v;})
  }

}
