//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public FlagAddedAndRemovedEventListenerComponent flagAddedAndRemovedEventListener { get { return (FlagAddedAndRemovedEventListenerComponent)GetComponent(TestComponentsLookup.FlagAddedAndRemovedEventListener); } }
    public bool hasFlagAddedAndRemovedEventListener { get { return HasComponent(TestComponentsLookup.FlagAddedAndRemovedEventListener); } }

    public void AddFlagAddedAndRemovedEventListener(System.Collections.Generic.List<IFlagAddedAndRemovedEventListener> newValue) {
        var index = TestComponentsLookup.FlagAddedAndRemovedEventListener;
        var component = CreateComponent<FlagAddedAndRemovedEventListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFlagAddedAndRemovedEventListener(System.Collections.Generic.List<IFlagAddedAndRemovedEventListener> newValue) {
        var index = TestComponentsLookup.FlagAddedAndRemovedEventListener;
        var component = CreateComponent<FlagAddedAndRemovedEventListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFlagAddedAndRemovedEventListener() {
        RemoveComponent(TestComponentsLookup.FlagAddedAndRemovedEventListener);
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
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherFlagAddedAndRemovedEventListener;

    public static Entitas.IMatcher<TestEntity> FlagAddedAndRemovedEventListener {
        get {
            if (_matcherFlagAddedAndRemovedEventListener == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.FlagAddedAndRemovedEventListener);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherFlagAddedAndRemovedEventListener = matcher;
            }

            return _matcherFlagAddedAndRemovedEventListener;
        }
    }
}