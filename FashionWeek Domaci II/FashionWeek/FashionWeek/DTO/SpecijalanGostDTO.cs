﻿namespace FashionWeek.DTO;

public class SpecijalanGostPregled
{
    public SpecijalanGostId Id { get; set; }

    #region Constructors
    public SpecijalanGostPregled() { }
    public SpecijalanGostPregled(SpecijalanGostId id)
    {
        Id = id;
    }
    #endregion
}

public class SpecijalanGostIdBasic
{
    public ModniKreatorBasic ModniKreator { get; set; }
    public ModnaRevijaBasic ModnaRevija { get; set; }
    public OrganizatorBasic Organizator { get; set; }

    #region Constructors
    public SpecijalanGostIdBasic() { }
    #endregion
}

public class SpecijalanGostBasic
{
    public SpecijalanGostIdBasic Id { get; set; }

    #region Constructors
    public SpecijalanGostBasic() { }
    public SpecijalanGostBasic(SpecijalanGostIdBasic id)
    {
        Id = id;
    }
    #endregion
}
