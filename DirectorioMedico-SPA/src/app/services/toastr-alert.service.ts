import { Injectable } from "@angular/core";
import { ToastrService } from "ngx-toastr";
import { trigger, state, style, transition, animate } from '@angular/animations'; 

@Injectable({
  providedIn: "root",
})
export class ToastrAlertService {
  constructor(private toastr: ToastrService) {}

  success(message: string) {
    return this.toastr.success(message, "Operación ejecutada exitosamente");
  }

  error(message: string) {
    return this.toastr.error(
      message,
      "Problemas en el momento de realizar la acción"
    );
  }

  info(message: string, tittle: string) {
    return this.toastr.info(message, tittle);
  }

  warning(message: string, tittle: string) {
    return this.toastr.warning(message, tittle);
  }
}
