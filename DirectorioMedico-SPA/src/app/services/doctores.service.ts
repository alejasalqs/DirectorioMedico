import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "../../environments/environment";
import { Observable } from "rxjs";
import { Doctor } from "../../models/Doctor";

/*

Creado por: asalguero
Fecha: 20/04/2020

*/

@Injectable({
  providedIn: "root",
})
export class DoctoresService {
  constructor(private http: HttpClient) {}
  baseURL = environment.apiURL;

  /**
   * Obtiene una lista con todos los doctores del endpoint.
   * @returns Observable
   */
  obtenerDoctores(): Observable<Doctor[]> {
    return this.http.get<Doctor[]>(this.baseURL + "doctores");
  }

  /**
   * Obtiene la información detallada de un Doctor mediante un ID.
   * @param id Identificador del Doctor que se desea consultar
   * @returns Observable
   */
  obtenerDoctoresID(id: any): Observable<Doctor> {
    return this.http.get<Doctor>(this.baseURL + "doctores/" + id);
  }

  agregarDoctor(doctor: any) {
    this.http.post(this.baseURL + "doctores", doctor);
  }

  editarDoctor(doctor: any, id: any) {
    this.http.post(this.baseURL + "doctores/" + id, doctor);
  }

  eliminarDoctor(doctor: any, id: any) {
    this.http.post(this.baseURL + "doctores/" + id, doctor);
  }
}
