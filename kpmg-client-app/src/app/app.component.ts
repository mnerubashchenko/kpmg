import { Component } from '@angular/core';
import {Person} from './interfaces/interfaces';
import {HttpService} from './services/http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(public httpService: HttpService) {
  }

  people: Person[] = []

  getPeople(): void {
    this.httpService.getData().subscribe(res => this.people = res, error => console.error(error))
  }

  clear() {
    this.people = []
  }
}
