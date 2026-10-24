FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(-20.9, 0) * mm, "end": v(20.8, 0) * mm});
            skLineSegment(sketch, "E1", {"start": v(20.8, 1.2) * mm, "end": v(20.8, 5.62) * mm});
            skFitSpline(sketch, "E2", {"points": [v(20.8, 5.62) * mm, v(20.78, 5.6) * mm, v(20.76, 5.58) * mm, v(20.73, 5.55) * mm, v(20.7, 5.53) * mm, v(20.66, 5.51) * mm, v(20.61, 5.5) * mm, v(20.6, 5.5) * mm, v(20.57, 5.5) * mm, v(20.55, 5.5) * mm, v(20.53, 5.5) * mm, v(20.5, 5.51) * mm, v(20.45, 5.53) * mm, v(20.42, 5.55) * mm, v(20.39, 5.6) * mm, v(20.36, 5.63) * mm, v(20.34, 5.65) * mm, v(20.32, 5.68) * mm], "startDerivative": vector(-0.35, -0.48) * mm, "endDerivative": vector(-0.38, 0.34) * mm});
            skFitSpline(sketch, "E3", {"points": [v(20.32, 5.68) * mm, v(20.3, 5.7) * mm, v(20.26, 5.72) * mm, v(20.21, 5.74) * mm, v(20.17, 5.74) * mm, v(20.14, 5.74) * mm], "startDerivative": vector(-0.1, 0.1) * mm, "endDerivative": vector(-0.12, 0) * mm});
            skLineSegment(sketch, "E4", {"start": v(20.14, 5.74) * mm, "end": v(-16.37, 5.74) * mm});
            skLineSegment(sketch, "E5", {"start": v(-16.37, 5.74) * mm, "end": v(-17.26, 5.24) * mm});
            skLineSegment(sketch, "E6", {"start": v(-17.26, 5.24) * mm, "end": v(-18.89, 5.24) * mm});
            skLineSegment(sketch, "E7", {"start": v(-18.89, 5.24) * mm, "end": v(-19.4, 5.74) * mm});
            skLineSegment(sketch, "E8", {"start": v(-20.9, 0) * mm, "end": v(-20.9, 5.95) * mm});
            skLineSegment(sketch, "E9", {"start": v(-19.4, 5.74) * mm, "end": v(-20.9, 5.95) * mm});
            skLineSegment(sketch, "E10", {"start": v(19.49, 0) * mm, "end": v(20.8, 0) * mm});
            skLineSegment(sketch, "E11", {"start": v(24.83, 0.5) * mm, "end": v(24.83, 0) * mm});
            skLineSegment(sketch, "E12", {"start": v(24.83, 0) * mm, "end": v(20.8, 0) * mm});
            skLineSegment(sketch, "E13", {"start": v(20.8, 1.2) * mm, "end": v(24.83, 1.2) * mm});
            skLineSegment(sketch, "E14", {"start": v(24.83, 0.5) * mm, "end": v(24.83, 1.2) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            cPlane(context, id + "F1", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 20.42 * mm, "width" : 150 * mm, "height" : 150 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E15", {"center": v(0, 0) * mm, "radius": 2.25 * mm});
            skCircle(sketch, "E16", {"center": v(0, 0) * mm, "radius": 3.25 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E2");Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":subQ0}),1.0]])]});}
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            revolve(context, id + "F3", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "depth" : 25 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.boolean.opBoolean","INTERSECT",EDGE,{"derivedFrom":[makeQuery(id+"F3.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8")])]}),makeQuery(id+"F4.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E15")])]})]});
            var Q1;
            Q1=makeQuery(id+"F4.boolean.opBoolean","INTERSECT",EDGE,{"derivedFrom":[makeQuery(id+"F3.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8")])]}),makeQuery(id+"F4.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F2.wireOp",EDGE,"E16")])]})]});
            fillet(context, id + "F5", {"entities" : qUnion([Q0, Q1]), "radius" : .2 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E17", {"start": v(-20.87, 3.5) * mm, "end": v(-19.81, 3.5) * mm});
            skLineSegment(sketch, "E18", {"start": v(-19.81, 3.5) * mm, "end": v(-19.81, 2) * mm});
            skLineSegment(sketch, "E19", {"start": v(-19.81, 2) * mm, "end": v(-20.87, 2) * mm});
            skArc(sketch, "E20", {"start": v(-20.87, 2) * mm, "mid": v(-20.71, 2.75) * mm, "end": v(-20.87, 3.5) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F6", true);
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E0");
            revolve(context, id + "F7", {"operationType" : NewBodyOperationType.ADD, "entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
    });