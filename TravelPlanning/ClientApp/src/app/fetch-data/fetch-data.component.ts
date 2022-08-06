import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

  funct() {
    var email = document.getElementById('emailfield');
    var password = document.getElementById('passwordfield');
    var name = document.getElementById('lastnamefield');
    var surname = document.getElementById('firstnamefield');
    var phoneNumber = document.getElementById('phonefield');
    var city = document.getElementById('cityfield');
    var country = document.getElementById('countryfield');
    var dateOfBirth = document.getElementById('birthdatefield');
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface User {
  email: string;
  password: string;
  name: string;
  surname: string;
  phoneNumber: string;
  city: string;
  country: string;
  dateOfBirth: Date;
}
