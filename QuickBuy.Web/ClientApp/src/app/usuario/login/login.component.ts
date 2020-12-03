import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]
})
export class LoginComponent {

  public usuario;

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "leo@teste.com" && this.usuario.senha == "abc123") {
      this.usuarioAutenticado = true;
    }
  }

  public enderecoimagem = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.undertheradarreport.com.au%2FCMSPages%2FGetFile.aspx%3Fguid%3Db4c1237d-3d8c-48b2-9683-8d0b0266b630&imgrefurl=https%3A%2F%2Fwww.undertheradarreport.com.au%2Fblog%2Fmay-2020%2Fwhich-shares-to-buy-now&tbnid=DH2b5wH006lExM&vet=12ahUKEwi2u_7986ztAhWaMLkGHcciDgAQMygEegUIARC0AQ..i&docid=vfY8f5XL2TDMcM&w=1920&h=1080&q=buy%20pictures&ved=2ahUKEwi2u_7986ztAhWaMLkGHcciDgAQMygEegUIARC0AQ";
}
