import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-india-usa',
  templateUrl: './india-usa.component.html',
  styleUrls: ['./india-usa.component.css']
})
export class IndiaUSAComponent implements OnInit {

  constructor(private router:ActivatedRoute,
              private route:Router) { }

  ngOnInit(): void {
  }

  viaAtlantic()
  {
    this.route.navigate(['atlantic'],{relativeTo:this.router});
  }

  viaPacific()
  {
    this.route.navigate(['pacific'],{relativeTo:this.router});
  }
}
