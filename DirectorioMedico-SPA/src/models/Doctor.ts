import { RedesSociale } from "./RedesSociales";
import { Especialidad } from "./Especialidad";
import { Estudio } from "./Estudio";
import { Experiencia } from "./Experiencia";
import { Idioma } from "./Idioma";

export interface Doctor {
  id?: number;
  nombre?: string;
  primer_apellido?: string;
  segundo_apellido?: string;
  correo?: string;
  sitio_web?: string;
  celular?: string;
  estado?: boolean;
  foto?: string;
  precio?: number;
  genero?: number;

  redesSociales?: RedesSociale[];
  telefono_oficina?: string;
  especialidades?: Especialidad[];
  estudios?: Estudio[];
  experiencia?: Experiencia[];
  idiomas?: Idioma[];
  fechaCreacion?: Date;
  fechaUltimaActividad?: Date;
  fechaNacimiento?: Date;
  sobreMi?: string;
}
