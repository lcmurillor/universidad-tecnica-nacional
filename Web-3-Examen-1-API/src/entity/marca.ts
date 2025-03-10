import { IsBoolean, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class marca {
    /**
     * Llave primaria de la tabla marca.
     */
    @PrimaryGeneratedColumn()
    id: number;

    /**
     * Nombre de la marca de los vheiculos.
     */
    @Column() @IsNotEmpty() @MaxLength(30)
    nombre: string;

    /**
     * Este atributo se puede indicar como un estado "true" para indicar que la marca tiene matalizado y "false" para indicar que no tiene matelizado.
     */
    @Column() @IsNotEmpty() @IsBoolean()
    metalizado: boolean;

    /**
     * Valor que inica que la marca esta activa o inactiva, siendo estos estados "true" y "false" respectivamente, una marca con estado inactivo no se puede usar en el sistema.
     */
    @Column() @IsNotEmpty() @IsBoolean()
    estado: boolean;
}