import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../../models/Users/user';


@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  private apiUrl = 'http://localhost:5120/api/User';

  constructor(private http: HttpClient) { }

  public getUser(): Observable<User[]> {
    return this.http.get<User[]>(this.apiUrl);
  }

  public create(apt: User){
    this.http.post(this.apiUrl, apt).subscribe(
        data => {
            console.log(data)
        },
        err => {
            console.log(err)
        },
        () => {
            console.log("Completed")
        });
  }
  
}
