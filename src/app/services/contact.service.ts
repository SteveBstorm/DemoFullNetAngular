import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Contact } from '../models/contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  private url : string = "https://localhost:44305/api/contact/"


  constructor(
    private _client : HttpClient,
    private _router : Router
  ) { }

  getAll() : Observable<Contact[]> 
  {
    return this._client.get<Contact[]>(this.url)
  }

  createContact(c : Contact) {
    this._client.post(this.url, c).subscribe({
      next : () => this._router.navigate(["/home"]),
      error : (error) => console.log(error)
    })
  }

  getOne(id : number) : Observable<Contact> {
    return this._client.get<Contact>(this.url+id)
  }

  delete(id : number) {
    this._client.delete(this.url+id).subscribe({
      next : () => console.log("ok"),
      error: (error) => console.log("pas ok")
    })
  }

  update(c : Contact) {
    this._client.put(this.url, c).subscribe({
      next : () => this._router.navigate(["/home"]),
      error : (error) => console.log(error)
    })
  }
}
