import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-listcontact',
  templateUrl: './listcontact.component.html',
  styleUrls: ['./listcontact.component.scss']
})
export class ListcontactComponent implements OnInit {

  listeContact : Contact[] = []

  constructor(
    private _contactService : ContactService
  ) { }

  ngOnInit(): void {
    this._contactService.getAll().subscribe(
      (data : Contact[]) => this.listeContact = data
    )
  }

  delete(id : number){
    this._contactService.delete(id)
  }

}
