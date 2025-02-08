import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Property } from '../../models/properties/property';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  private apiUrl = 'http://localhost:8080/api/Property';

  constructor(private http: HttpClient) { }

  public getProperties(): Observable<Property[]> {
    return this.http.get<Property[]>(this.apiUrl);
  }

  public create(apt: Property){
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
