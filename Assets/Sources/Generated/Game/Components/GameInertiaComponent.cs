//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public InertiaComponent inertia { get { return (InertiaComponent)GetComponent(GameComponentsLookup.Inertia); } }
    public bool hasInertia { get { return HasComponent(GameComponentsLookup.Inertia); } }

    public void AddInertia(float newValue) {
        var index = GameComponentsLookup.Inertia;
        var component = CreateComponent<InertiaComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceInertia(float newValue) {
        var index = GameComponentsLookup.Inertia;
        var component = CreateComponent<InertiaComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveInertia() {
        RemoveComponent(GameComponentsLookup.Inertia);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInertia;

    public static Entitas.IMatcher<GameEntity> Inertia {
        get {
            if (_matcherInertia == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Inertia);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInertia = matcher;
            }

            return _matcherInertia;
        }
    }
}
