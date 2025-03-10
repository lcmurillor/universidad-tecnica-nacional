import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { business } from "./business";

@Entity()
export class business_type {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(100)
    name: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    description: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    created_at: string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    updated_at: string;

    @OneToMany(type => business, business => business.business_type)
    business: business[];
}