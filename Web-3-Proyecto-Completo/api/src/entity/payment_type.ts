import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { order } from "./order";

@Entity()
export class payment_type{
    @PrimaryGeneratedColumn()
    id:number;

    @Column() @IsNotEmpty() @MaxLength(2)
    type:string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state:string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate() 
    created_at:string;

    @Column() @IsNotEmpty()
    updated_at:string;

    @OneToMany(type => order, order => order.payment_type)
    order: order[];
}