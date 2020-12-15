import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, ActivatedRouteSnapshot } from '@angular/router';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  fg : FormGroup

  currentContact : Contact
  constructor(
    private _service : ContactService,
    private _builder : FormBuilder,
    private _activatedRoute : ActivatedRoute
  ) { }

  ngOnInit(): void {

    this._service.getOne(this._activatedRoute.snapshot.params["id"]).subscribe(
      (data : Contact) => {
        this.currentContact = data 
        this.formInit()
      }
    )

    
  }

  formInit()
  {
    this.fg = this._builder.group({
      firstName : [this.currentContact.firstName, Validators.required],
      lastName : [this.currentContact.lastName, Validators.required],
      email : [this.currentContact.email, [Validators.required, Validators.email]]
    })
  }

  update() {
    const newContact = new Contact()
    let values = this.fg.value
    //récupérer les info venant du formGroup
    newContact.id = this.currentContact.id
    newContact.firstName= values["firstName"]
    newContact.lastName= values["lastName"]
    newContact.email= values["email"]

    this._service.update(newContact)    
  }


}
