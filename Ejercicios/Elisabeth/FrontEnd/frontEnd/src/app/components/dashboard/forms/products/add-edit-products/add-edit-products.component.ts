import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { Product } from '../../../../../interfaces/product';

@Component({
  selector: 'app-add-edit-products',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './add-edit-products.component.html',
  styleUrl: './add-edit-products.component.css'
})
export class AddEditProductsComponent {
  formProduct: FormGroup;
  constructor(private fb: FormBuilder){
    this.formProduct = fb.group({
      name: ['', Validators.required, Validators.maxLength(20)],
      description: ['', Validators.required, Validators.maxLength(250)],
      code: ['', Validators.required, Validators.maxLength(10)],
      buyPrice: [null, Validators.required],
      sellPrice: [null, Validators.required],
      margin: [null, Validators.required]
    })
  }
  addProduct(){
  // console.log(this.formProduct.value.name) // forma de acceder el valor de la propiedad name
  // console.log(this.formProduct.get('name')?.value) // otra forma de acceder al valor

  // Obtener el valor de las propiedades
  // const product: Product = {
  //   Name: this.formProduct.value.name,
  //   Description: this.formProduct.value.description,
  //   Code: this.formProduct.value.code,
  //   BuyPrice: this.formProduct.value.buyPrice,
  //   SellPrice: this.formProduct.value.sellPrice,
  //   Margin: this.formProduct.value.margin
  // }
  // console.log(product);
  }

}
