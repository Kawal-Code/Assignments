import { Component, OnInit } from '@angular/core';
import { Route } from '@angular/compiler/src/core';
import {Router} from "@angular/router";
import { Product } from '../product';
@Component({
  selector: 'app-pro-view',
  templateUrl: './pro-view.component.html',
  styleUrls: ['./pro-view.component.css']
})
export class ProViewComponent implements OnInit {
  //pname: string;
  prolist :Product[]=[];
  constructor( private router : Router) {
    //this.pname = localStorage.getItem("pname")
  this.prolist=JSON.parse(localStorage.getItem("prolist"))
   }

  ngOnInit(): void {
  }
  Back()
  {
    localStorage.clear;
    this.router.navigate(['/add'])
  }
}
