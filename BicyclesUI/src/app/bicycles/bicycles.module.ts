import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainPageComponent } from './main-page/main-page.component';
import { RouterModule } from '@angular/router';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    MainPageComponent],
  imports: [
    CommonModule,
    NgSelectModule,
    FormsModule,
    RouterModule.forRoot([{path: '', component: MainPageComponent}])
  ]
})
export class BicyclesModule { }
