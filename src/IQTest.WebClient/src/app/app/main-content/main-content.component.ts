import { Component, OnInit } from '@angular/core';

import { faTv, faClock, faDollarSign, faSmile } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-main-content',
  templateUrl: './main-content.component.html',
  styleUrls: ['./main-content.component.css']
})
export class MainContentComponent implements OnInit {
  faTv = faTv;
  faClock = faClock;
  faDollarSign = faDollarSign;
  faSmile = faSmile;

  constructor() { }

  ngOnInit(): void {
  }

}
