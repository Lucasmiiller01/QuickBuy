import { Component } from "@angular/core";

@Component({
  selector: "app-product",
  styleUrls: ["./product.component.css"],
  templateUrl:  "./product.component.html"

})

export class ProductComponent  {
  public id: number;
  public name: string;
  public price: number;
  public releasedForSale: boolean;

  public getName(): string {
    return "tetes";
  };


}
