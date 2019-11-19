import { Injectable } from '@angular/core';
import { HttpClient } from 'selenium-webdriver/http';

@Injectable({
  providedIn: 'root'
})
export class MyServiceService {
  Url :string; 

  constructor(private http : HttpClient) {
    this.Url = '';
   }

   SearchClient()
   {
      

   }

   AddClient(){
     

   }
}
