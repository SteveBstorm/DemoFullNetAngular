import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DetailsComponent } from './components/details/details.component';
import { ListcontactComponent } from './components/listcontact/listcontact.component';
import { NewcontactComponent } from './components/newcontact/newcontact.component';
import { UpdateComponent } from './components/update/update.component';

const routes: Routes = [
  { path : 'home', component : ListcontactComponent},
  { path : 'newcontact', component : NewcontactComponent},
  { path : 'detail/:id', component : DetailsComponent},
  { path : 'update/:id', component : UpdateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
