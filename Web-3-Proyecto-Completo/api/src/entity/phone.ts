import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, PrimaryGeneratedColumn, Unique } from "typeorm";
import { business } from "./business";


@Entity()
@Unique(['number'])
export class phone{
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(15)
    number: number;

    @Column() @IsNotEmpty()
    created_at: string;

    @Column() @IsNotEmpty()
    updated_at: string;

    @ManyToOne(type => business, business => business.phone)
    business: business;
}
