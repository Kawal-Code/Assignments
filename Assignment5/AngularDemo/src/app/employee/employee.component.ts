import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
list: Employee[]
constructor() {
  this.list= [
     {eid:1, ename:"Kawal", designation:"Developer",joinDate: new Date(2010,10,10) , salary: 1000},
     {eid:1, ename:"Santosh", designation:"Manager",joinDate: new Date(2010,1,10) , salary: 2000},
     {eid:1, ename:"Kajal", designation:"Developer",joinDate: new Date(2010,10,1) , salary: 3000},
]
}

  

  ngOnInit(): void {
  }

}
