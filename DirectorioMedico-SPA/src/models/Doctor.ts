import { RedesSociale } from './RedesSociales';
import { Especialidad } from './Especialidad';
import { Estudio } from './Estudio';
import { Experiencia } from './Experiencia';

export interface Doctor {
    id: number;
    nombre: string;
    primer_apellido: string;
    segundo_apellido: string;
    correo: string;
    sitio_web: string;
    redesSociales: RedesSociale[];
    celular: string;
    telefono_oficina: string;
    especialidades: Especialidad[];
    estudios: Estudio[];
    experiencia: Experiencia[];
    estado: boolean;
    fechaCreacion: Date;
    fechaUltimaActividad: Date;
    fechaNacimiento: Date;
    foto: string;
}