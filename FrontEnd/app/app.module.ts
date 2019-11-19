import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormClientComponent } from './form-client/form-client.component';
import { HeadingClientComponent } from './heading-client/heading-client.component';
import { ClientTableComponent } from './client-table/client-table.component';
import { FormsModule } from '@angular/forms';

import {HttpClientModule} from '@angular/common/http';
import { from } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
    FormClientComponent,
    HeadingClientComponent,
    ClientTableComponent
    
    
  ],
  imports: [BrowserModule,AppRoutingModule,HttpClientModule,FormsModule],
  providers:[],
  bootstrap: [AppComponent]
})
export class AppModule { }
