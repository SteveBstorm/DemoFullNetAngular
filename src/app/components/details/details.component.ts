import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {

  currentContact : Contact

  constructor(
    private _service : ContactService,
    private _activatedRoute : ActivatedRoute
  ) { }

  ngOnInit(): void {
    this._service.getOne(this._activatedRoute.snapshot.params["id"]).subscribe(
      (data : Contact) => this.currentContact = data
    )

  }

}
