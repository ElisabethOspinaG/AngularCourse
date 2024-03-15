import { Product } from './../../../../../../interfaces/product';
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { ProductService } from '../../../../../../services/product.service';
import { NavbarProductsComponent } from '../../navbar-products/navbar-products.component';

@Component({
  selector: 'app-list-products',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink, NavbarProductsComponent],
  templateUrl: './list-products.component.html',
  styleUrl: './list-products.component.css'
})
export class ListProductsComponent {
  listProducts: Product[] = [ ];
  
  constructor(private productService: ProductService) { }
  
  ngOnInit(): void{
    this.ShowProducts();
  };

  ShowProducts(): void{

    this.productService.ShowListProducts().subscribe(result =>{
      this.listProducts = result;
    // console.log('info listProducts: ', this.listProducts);
     console.log("informacion de result: ", result);
    })
  };
}
