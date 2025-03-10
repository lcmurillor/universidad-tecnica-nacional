import { IsNotEmpty, MaxLength, IsDate } from "class-validator";
import { Column, Entity, ManyToOne, PrimaryGeneratedColumn, Unique } from "typeorm";
import { business } from "./business";

@Entity()
@Unique(['name'])
export class photo{
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(250)  
    name: string;

    @Column() @IsNotEmpty()
    created_at: string;

    @Column() @IsNotEmpty() 
    updated_at: string;

    @ManyToOne(type => business, business => business.photo)
    business: business;
}
