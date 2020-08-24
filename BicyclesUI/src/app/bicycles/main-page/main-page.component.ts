import { Component, OnInit } from '@angular/core';
import { GetBicycleView } from 'src/app/shared/models/GetBicycleView';
import { AddBicycleView } from 'src/app/shared/models/AddBicycleView';
import { BicycleService } from 'src/app/shared/services/bicycle.service';
import { UpdateBicycleView } from 'src/app/shared/models/UpdateBicycleView';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {

  public bicycles: GetBicycleView[] = [];
  public rentedBicycles: GetBicycleView[] = [];
  public availableBicycles: GetBicycleView[] = [];
  public addBicycleView: AddBicycleView = new AddBicycleView();
  public updateBicycleView: UpdateBicycleView = new UpdateBicycleView();
  public types: string[] = ['Mountain', 'Road', 'BMX', 'Cyclocross'];

  constructor(private bicycleService: BicycleService) { }

  ngOnInit(): void {
    this.getBicycles();
  }

  public getBicycles() {
    this.bicycleService.getBicycles().subscribe(res => {
      this.bicycles = res;
      this.rentedBicycles = res.filter(bicycle => bicycle.rented === true);
      this.availableBicycles = res.filter(bicycle => bicycle.rented === false);
    })
  }

  public addBicycle() {
    this.addBicycleView.rented = false;
    this.bicycleService.addBicycle(this.addBicycleView).subscribe(res => { this.getBicycles(); });
  }

  public rentBike(bike: GetBicycleView) {
    this.updateBicycleView = {
      id: bike.id,
      name: bike.name,
      type: bike.type,
      price: bike.price,
      rented: true
    }
    this.bicycleService.updateBicycle(this.updateBicycleView).subscribe(res => {this.getBicycles(); });
  }

  public cancelRent(bike: GetBicycleView) {
    this.updateBicycleView = {
      id: bike.id,
      name: bike.name,
      type: bike.type,
      price: bike.price,
      rented: false
    }
    this.bicycleService.updateBicycle(this.updateBicycleView).subscribe(res => {this.getBicycles(); });
  }

  public deleteBicycle(id:string) {
    this.bicycleService.deleteBicycle(id).subscribe(res => {this.getBicycles(); });
  }

}
