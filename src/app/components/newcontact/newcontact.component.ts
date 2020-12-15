import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-newcontact',
  templateUrl: './newcontact.component.html',
  styleUrls: ['./newcontact.component.scss']
})
export class NewcontactComponent implements OnInit {

  fg : FormGroup
  constructor(
    private _service : ContactService,
    private _builder : FormBuilder
  ) { }

  ngOnInit(): void {
    this.fg = this._builder.group({
      firstName : ['', Validators.required],
      lastName : ['', Validators.required],
      email : ['', [Validators.required, Validators.email]]
    })
  }

  create() {
    const newContact = new Contact()
    let values = this.fg.value
    //récupérer les info venant du formGroup

    newContact.firstName= values["firstName"]
    newContact.lastName= values["lastName"]
    newContact.email= values["email"]

    this._service.createContact(newContact)    
  }

}
