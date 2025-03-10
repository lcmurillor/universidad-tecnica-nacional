import { IsNotEmpty, IsBoolean, MaxLength } from "class-validator";
import { Column, Entity, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class tipo_vehiculo{
    /**
     * Llave primaria de la tabla tipo_vehiculo.
     */
    @PrimaryGeneratedColumn()
    id: number;
    
    /**
     * Nombre del tipo de vehiculo.
     */
    @Column() @IsNotEmpty()  @MaxLength(10)
    nombre: string;

    /**
     * Valor que inica que el tipo de vehiculo esta activo o inactivo, siendo estos estados "true" y "false" respectivamente, un tipo de vehiculo con estado inactivo no se puede usar en el sistema.
     */
    @Column() @IsNotEmpty() @IsBoolean()
    estado: boolean;
}