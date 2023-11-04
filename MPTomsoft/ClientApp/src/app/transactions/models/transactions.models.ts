export interface TransactionPayments {
    obracun_placanja: TransactionPayment[];
}

export interface TransactionPayment {
    vrste_placanja_uid: string;
    naziv: string;
    iznos: number;
    nadgrupa_placanja_uid: string;
    nadgrupa_placanja_naziv: string;
}

export interface TransactionProducts {
    obracun_artikli: TransactionProduct[];
}

export interface TransactionProduct {
    artikl_uid: string;
    naziv_artikla: string;
    kolicina: number;
    iznos: number;
    usluga: string;
}