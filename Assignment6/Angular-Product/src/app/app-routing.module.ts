import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProViewComponent } from './pro-view/pro-view.component';
import { ProAddComponent } from './pro-add/pro-add.component';


const routes: Routes = [
  {path:'add',component:ProAddComponent},
   {path:'view',component:ProViewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
