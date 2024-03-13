import { Product } from './../../../../../../interfaces/product';
import { Component, OnInit } from '@angular/core';
import { CompilerConfig } from '@angular/compiler';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ProductService } from '../../../../../../services/product.service';

@Component({
  selector: 'app-list-products',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.css'
})
export class ListProductsComponent implements OnInit{
  listProducts: Product[] = [
    {Name: "polietileno Alta Densidad", Description: "Material conocido como plástico soplado", Code: "0001", BuyPrice: 1500, SellPrice: 2000, Margin: 500},
    {Name: "polietileno Baja Densidad", Description: "Se hace plástico burbujas, bolsas, papel film, etc,", Code: "0002", BuyPrice: 1000, SellPrice: 1200, Margin: 200},
    {Name: "polipropileno", Description: "Esta en tapas envases, recipientes, canastas, etc ", Code: "0003", BuyPrice: 1200, SellPrice: 1800, Margin: 600},
    {Name: "pet", Description: "producto para fabricar varias cosas", Code: "001", BuyPrice: 1000, SellPrice: 1200, Margin: 200}
  ]

  constructor(private products: ProductService) {  }
  ListProducts(): void{

    // this.products.ShowListProducts(data).suscribe(result =>{
    //   if (result == true) {

    //   }else{

    //   }
    // })
  }

  ngOnInit(): void {

  }
}
