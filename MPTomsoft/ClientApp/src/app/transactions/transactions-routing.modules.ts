import { RouterModule, Routes } from "@angular/router";
import { TransactionsPaymentComponent } from "./payment/transactions-payment.component";
import { TransactionsProductComponent } from "./product/transactions-product.component";
import { NgModule } from "@angular/core";

const routes: Routes = [
    { path: "transactions", children: [
        { path: "payments", component: TransactionsPaymentComponent },
        { path: "products", component: TransactionsProductComponent }
    ]}
  ];
  
  @NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })
  export class TransactionsRoutingModule { }