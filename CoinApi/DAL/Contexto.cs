using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Coins> Coins { get; set; }
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coins>().HasData(
            new Coins { MonedaId = 1, Descripcion = "Bitcoin", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/1487/PNG/512/8369-bitcoin_102502.png" },
            new Coins { MonedaId = 2, Descripcion = "Ethereum", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png" },
            new Coins { MonedaId = 3, Descripcion = "Litecoin", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/2648/PNG/512/finance_litecoin_icon_160836.png" },
            new Coins { MonedaId = 4, Descripcion = "Ripple", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3392/PNG/512/ripple_icon_213731.png" },
            new Coins { MonedaId = 5, Descripcion = "Stellar", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3350/PNG/512/cryptocurrencies_stellar_coin_money_icon_210245.png" },
            new Coins { MonedaId = 6, Descripcion = "Tether", Valor = 8100, ImageUrl = "https://iconape.com/wp-content/files/ac/209643/png/tether-usdt-logo.png" },
            new Coins { MonedaId = 7, Descripcion = "EOS", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/1384/PNG/512/eos-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95175.png" },
            new Coins { MonedaId = 8, Descripcion = "Cardano", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/3279/PNG/512/cardano_ada_coin_icon_208056.png" },
            new Coins { MonedaId = 9, Descripcion = "Dash", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/1386/PNG/512/dash-crypto-cryptocurrency-cryptocurrencies-cash-money-bank-payment_95627.png" },
            new Coins { MonedaId = 10, Descripcion = "Zcash", Valor = 8100, ImageUrl = "https://cdn.icon-icons.com/icons2/2699/PNG/512/zcash_logo_icon_169679.png" }
        );
    }
}