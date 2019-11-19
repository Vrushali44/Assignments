import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/Http';
import { Observable } from 'rxjs';
import {ClientModel}from './client-model';

@Injectable({
  providedIn: 'root'
})
export class ClientServiceService {
  private Url='https://localhost:44360/';

  constructor(private http:HttpClient) { }


SearchClient(resultData:ClientModel):Observable<ClientModel[]>
{
  let NewUrl=`${this.Url}searchClient/`;
  if(resultData.firstName !=undefined){
    NewUrl=`${NewUrl}${resultData.firstName}/`
  }
  if(resultData.lastName !=undefined){
    NewUrl=`${NewUrl}${resultData.lastName}/`
  }

  console.log(NewUrl);
  return this.http.get<ClientModel[]>(NewUrl);

}

}