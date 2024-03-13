import { ToastrService } from 'ngx-toastr';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { Product } from '../../../../../interfaces/product';
import { ProductService } from '../../../../../services/product.service';
import { LoadingComponent } from '../../../../../shared/loading/loading.component';

@Component({
  selector: 'app-add-edit-products',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterLink],
  templateUrl: './add-edit-products.component.html',
  styleUrl: './add-edit-products.component.css'
})
export class AddEditProductsComponent {
  formProduct: FormGroup;
  loading: boolean= false;

  constructor(private fb: FormBuilder,
    private toastr: ToastrService,
    private router: Router,
    private products: ProductService,
    private loadin: LoadingComponent
    ){
    this.formProduct = fb.group({
      Name: ['', Validators.required, Validators.maxLength(20)],
      Description: ['', Validators.required, Validators.maxLength(250)],
      Code: ['', Validators.required, Validators.maxLength(10)],
      buyPrice: [null, Validators.required],
      sellPrice: [null, Validators.required],
      margin: [null, Validators.required]
    })
  }
  addProduct(){
    console.log(this.formProduct)
  // console.log(this.formProduct.value.name) // forma de acceder el valor de la propiedad name
  // console.log(this.formProduct.get('name')?.value) // otra forma de acceder al valor name

  //Obtener el valor de las propiedades
  const product: Product = {
    Name: this.formProduct.value.name,
    Description: this.formProduct.value.description,
    Code: this.formProduct.value.code,
    BuyPrice: this.formProduct.value.buyPrice,
    SellPrice: this.formProduct.value.sellPrice,
    Margin: this.formProduct.value.margin
  }
  this.loading = true;
  setTimeout( () => {
    this.products.CreateProducts(product).subscribe((result) =>{
      if(result){
          this.toastr.success('Producto Creado Exitosamente');
          this.formProduct.reset();
          this.router.navigate(['/dashboard'])
      }else{
          this.toastr.error('El nombre del producto ya existe, nose puede crear el producto','Error')
          this.formProduct.reset()
      }
    });

  }, 3000)
  console.log(product);
  }

}
