import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from "@angular/forms";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProAddComponent } from './pro-add/pro-add.component';
import { ProViewComponent } from './pro-view/pro-view.component';

@NgModule({
  declarations: [
    AppComponent,
    ProAddComponent,
    ProViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
