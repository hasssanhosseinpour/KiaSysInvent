import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable, of } from 'rxjs';
import { User } from '../_models/user';
import { Router } from '@angular/router';
@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model : any = {}

  constructor(public accountService:AccountService,private router:Router) { }

  ngOnInit(): void {

  }
  
  login(){
    this.accountService.login(this.model).subscribe({
      //since we don't need the response, we can put _ or ()
      //there is only one statement so we don't need {} too 
      next: _=> this.router.navigateByUrl("/members"),
  
      //error:error=>this.toastr.error(error.error)
    })
  }

  logout(){
    this.accountService.logout();
    this.router.navigateByUrl("/");
    //this.loggedIn = false;
  }
}