import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import {Router} from "@angular/router";

@Component({
  selector: 'app-pro-add',
  templateUrl: './pro-add.component.html',
  styleUrls: ['./pro-add.component.css']
})
export class ProAddComponent implements OnInit {

prolist: Product[]=[];
//item: Product;
obj:Product;
pid: number;
pname: string;
price: number;
stock:number;


  constructor(private router: Router) { 
    this.obj = new Product
    
  }

  ngOnInit(): void {
  }
   
   validate()
   {this.obj ={pname: this.pname,pid: this.pid,price:this.price, stock:this.stock};
     this.prolist.push(this.obj)
     localStorage.setItem("prolist", JSON.stringify(this.prolist))
     //localStorage.setItem("pname", this.obj.pname)
  //this.router.navigateByUrl('/view')

   
  }
}
