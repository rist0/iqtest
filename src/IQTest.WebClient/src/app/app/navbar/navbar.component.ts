import { Component, OnInit } from '@angular/core';

import { UserService } from '../../_services/user.service';
import { IUser } from 'src/app/_models';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  loggedUser: IUser;

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.userService.user.subscribe(u => this.loggedUser = u);
  }

  logout() {
    this.userService.logout();
  }

}
